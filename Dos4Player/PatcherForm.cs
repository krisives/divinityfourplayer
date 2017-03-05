using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dos4Player
{
    public partial class PatcherForm : Form
    {
        public GameVersion detectedVersion = null;
        public bool patched = false;
        public string binaryFile;
        public string shippingDir;
        public string gameDir;
        public string dataDir;
        public string modsDir;
        public string modsMainDir;
        public string metaFile;
        public int patchOffset = -1;
        public byte[] exeBytes = null;

        public PatcherForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            patchButton.Enabled = restoreButton.Enabled = false;
            detectedVersion = null;
            patched = false;

            foreach (string path in checkPaths)
            {
                if (Directory.Exists(path))
                {
                    openFileDialog.InitialDirectory = path;
                }
            }

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (openFileDialog.FileNames.Length <= 0)
            {
                return;
            }
            
            binaryFile = openFileDialog.FileName;
            pathTextBox.Text = binaryFile;

            shippingDir = Directory.GetParent(binaryFile).FullName;
            gameDir = Directory.GetParent(shippingDir).FullName;
            dataDir = Path.Combine(gameDir, "Data");
            modsDir = Path.Combine(dataDir, "Mods");
            modsMainDir = Path.Combine(modsDir, "Main");
            metaFile = Path.Combine(modsMainDir, "meta.lsx");

            exeBytes = File.ReadAllBytes(binaryFile);

            if (exeBytes == null || exeBytes.Length <= 0)
            {
                versionLabel.Text = "Game .exe is missing";
                return;
            }

            foreach (GameVersion version in knownVersions)
            {
                patchOffset = SearchBytes(exeBytes, version.find);

                if (patchOffset > 0)
                {
                    detectedVersion = version;
                    patched = false;
                    break;
                }

                patchOffset = SearchBytes(exeBytes, version.replace);

                if (patchOffset > 0)
                {
                    detectedVersion = version;
                    patched = true;
                    break;
                }
            }

            if (detectedVersion == null)
            {
                versionLabel.Text = "Unknown";
                patchedLabel.Text = "No";
                return;
            }

            versionLabel.Text = detectedVersion.name;
            patchedLabel.Text = patched ? "Yes" : "No";
            patchButton.Enabled = !patched;
            restoreButton.Enabled = patched;
        }

        public static int SearchBytes(byte[] haystack, byte[] needle)
        {
            var len = needle.Length;
            var limit = haystack.Length - len;
            for (var i = 0; i <= limit; i++)
            {
                var k = 0;
                for (; k < len; k++)
                {
                    if (needle[k] != haystack[i + k]) break;
                }
                if (k == len) return i;
            }
            return -1;
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            for (int i=0; i < detectedVersion.find.Length; i++)
            {
                exeBytes[patchOffset + i] = detectedVersion.replace[i];
            }

            File.WriteAllBytes(binaryFile, exeBytes);
            patchedLabel.Text = "Yes";
            patchButton.Enabled = false;
            restoreButton.Enabled = true;

            File.WriteAllText(metaFile, Properties.Resources.meta);
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < detectedVersion.replace.Length; i++)
            {
                exeBytes[patchOffset + i] = detectedVersion.find[i];
            }

            File.WriteAllBytes(binaryFile, exeBytes);
            patchedLabel.Text = "No";
            patchButton.Enabled = true;
            restoreButton.Enabled = false;

            if (File.Exists(metaFile))
            {
                File.Delete(metaFile);
            }
        }

        private static string[] checkPaths =
        {
            "C:\\GOG Games\\Divinity - Original Sin Enhanced Edition\\Shipping"
        };

        private static GameVersion[] knownVersions =
        {
            new GameVersion(
                "2.0.119.430",
                "B4 03 00 00 48 3B D0 40 0F 93 C7 48 8B CB 48 89 6C 24",
                "B4 03 00 00 48 3B D0 31 C0 F7 D0 48 8B CB 48 89 6C 24"
            ),

            new GameVersion(
                "2.0.113.775",
                "B4 03 00 00 48 3B D0 40 0F 93 C7 48 8B CB 48 89 6C 24",
                "B4 03 00 00 48 3B D0 31 C0 F7 D0 48 8B CB 48 89 6C 24"
            ),

            new GameVersion(
                "2.0.104.737",
                "9C 03 00 00 48 3B D0 40 0F 93 C7 48 8B CB 48 89 6C 24",
                "9C 03 00 00 48 3B D0 31 C0 F7 D0 48 8B CB 48 89 6C 24"
            ),

            new GameVersion(
                "2.0.100.40",
                "30 8B 81 64 03 00 00 48 3B D0 40 0F 93 C7 48 8B CB 48",
                "30 8B 81 64 03 00 00 48 3B D0 31 C0 F7 D0 48 8B CB 48"
            ),

            new GameVersion(
                "2.0.99.676",
                "48 89 6C 24 28 FF 15 CD F4 50 00 40 0F B6 C7 48 8B 4C 24 60 48 33 CC E8 24 2D 91",
                "48 89 6C 24 28 FF 15 CD F4 50 00 31 C0 F7 D0 48 8B 4C 24 60 48 33 CC E8 24 2D 91"
            ),

            new GameVersion(
                "2.0.99.113",
                "41 4A 00 40 0F B6 C7 48 8B 4C 24 60 48 33 CC E8 34 38 AA FF",
                "41 4A 00 31 C0 F7 D0 48 8B 4C 24 60 48 33 CC E8 34 38 AA FF"
            )
        };
    }
}
