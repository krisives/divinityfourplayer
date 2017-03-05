using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos4Player
{
    public class GameVersion
    {
        public string name;
        public byte[] find;
        public byte[] replace;

        public GameVersion(string version, string find, string replace)
        {
            this.name = version;
            this.find = decodeHex(find);
            this.replace = decodeHex(replace);
        }

        public static byte[] decodeHex(string text)
        {
            text = text.Replace(" ", "");
            text = text.Replace("\t", "");

            return Enumerable.Range(0, text.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(text.Substring(x, 2), 16))
                .ToArray();
        }
    };
}
