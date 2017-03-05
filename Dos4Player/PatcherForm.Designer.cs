namespace Dos4Player
{
    partial class PatcherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary> 
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatcherForm));
            this.browseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.patchButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.versionInfoLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.patchedInfoLabel = new System.Windows.Forms.Label();
            this.patchedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(261, 11);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(66, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(189, 20);
            this.pathTextBox.TabIndex = 4;
            // 
            // patchButton
            // 
            this.patchButton.Enabled = false;
            this.patchButton.Location = new System.Drawing.Point(180, 72);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 23);
            this.patchButton.TabIndex = 8;
            this.patchButton.Text = "Patch";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Enabled = false;
            this.restoreButton.Location = new System.Drawing.Point(99, 72);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 8;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "EoCApp.exe|EoCApp.exe|All Files|*.*";
            // 
            // versionInfoLabel
            // 
            this.versionInfoLabel.AutoSize = true;
            this.versionInfoLabel.Location = new System.Drawing.Point(8, 45);
            this.versionInfoLabel.Name = "versionInfoLabel";
            this.versionInfoLabel.Size = new System.Drawing.Size(45, 13);
            this.versionInfoLabel.TabIndex = 9;
            this.versionInfoLabel.Text = "Version:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(59, 45);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 13);
            this.versionLabel.TabIndex = 10;
            // 
            // patchedInfoLabel
            // 
            this.patchedInfoLabel.AutoSize = true;
            this.patchedInfoLabel.Location = new System.Drawing.Point(149, 45);
            this.patchedInfoLabel.Name = "patchedInfoLabel";
            this.patchedInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.patchedInfoLabel.TabIndex = 11;
            this.patchedInfoLabel.Text = "Patched:";
            // 
            // patchedLabel
            // 
            this.patchedLabel.AutoSize = true;
            this.patchedLabel.Location = new System.Drawing.Point(205, 45);
            this.patchedLabel.Name = "patchedLabel";
            this.patchedLabel.Size = new System.Drawing.Size(0, 13);
            this.patchedLabel.TabIndex = 12;
            // 
            // PatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 102);
            this.Controls.Add(this.patchedLabel);
            this.Controls.Add(this.patchedInfoLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionInfoLabel);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatcherForm";
            this.Text = "DoS 4 Player Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label versionInfoLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label patchedInfoLabel;
        private System.Windows.Forms.Label patchedLabel;
    }
}

