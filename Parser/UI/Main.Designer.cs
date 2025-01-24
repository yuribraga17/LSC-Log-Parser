namespace Parser.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DirectoryPath = new System.Windows.Forms.RichTextBox();
            Browse = new System.Windows.Forms.Button();
            Parsed = new System.Windows.Forms.RichTextBox();
            CopyParsedToClipboard = new System.Windows.Forms.Button();
            SaveParsed = new System.Windows.Forms.Button();
            Parse = new System.Windows.Forms.Button();
            SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            PathLabel = new System.Windows.Forms.Label();
            Version = new System.Windows.Forms.Label();
            RemoveTimestamps = new System.Windows.Forms.CheckBox();
            DirectoryBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            MenuStrip = new System.Windows.Forms.MenuStrip();
            ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DirectoryPath
            // 
            DirectoryPath.DetectUrls = false;
            resources.ApplyResources(DirectoryPath, "DirectoryPath");
            DirectoryPath.Name = "DirectoryPath";
            DirectoryPath.ShortcutsEnabled = false;
            DirectoryPath.MouseClick += DirectoryPath_MouseClick;
            DirectoryPath.TextChanged += DirectoryPath_TextChanged;
            DirectoryPath.KeyDown += DirectoryPath_KeyDown;
            // 
            // Browse
            // 
            resources.ApplyResources(Browse, "Browse");
            Browse.Name = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // Parsed
            // 
            Parsed.DetectUrls = false;
            resources.ApplyResources(Parsed, "Parsed");
            Parsed.Name = "Parsed";
            // 
            // CopyParsedToClipboard
            // 
            resources.ApplyResources(CopyParsedToClipboard, "CopyParsedToClipboard");
            CopyParsedToClipboard.Name = "CopyParsedToClipboard";
            CopyParsedToClipboard.UseVisualStyleBackColor = true;
            CopyParsedToClipboard.Click += CopyParsedToClipboard_Click;
            // 
            // SaveParsed
            // 
            resources.ApplyResources(SaveParsed, "SaveParsed");
            SaveParsed.Name = "SaveParsed";
            SaveParsed.UseVisualStyleBackColor = true;
            SaveParsed.Click += SaveParsed_Click;
            // 
            // Parse
            // 
            resources.ApplyResources(Parse, "Parse");
            Parse.Name = "Parse";
            Parse.UseVisualStyleBackColor = true;
            Parse.Click += Parse_Click;
            // 
            // PathLabel
            // 
            resources.ApplyResources(PathLabel, "PathLabel");
            PathLabel.Name = "PathLabel";
            // 
            // Version
            // 
            resources.ApplyResources(Version, "Version");
            Version.Name = "Version";
            // 
            // RemoveTimestamps
            // 
            resources.ApplyResources(RemoveTimestamps, "RemoveTimestamps");
            RemoveTimestamps.Name = "RemoveTimestamps";
            RemoveTimestamps.UseVisualStyleBackColor = true;
            // 
            // DirectoryBrowserDialog
            // 
            resources.ApplyResources(DirectoryBrowserDialog, "DirectoryBrowserDialog");
            DirectoryBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DirectoryBrowserDialog.ShowNewFolderButton = false;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ServerToolStripMenuItem, AboutToolStripMenuItem });
            resources.ApplyResources(MenuStrip, "MenuStrip");
            MenuStrip.Name = "MenuStrip";
            // 
            // ServerToolStripMenuItem
            // 
            ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            resources.ApplyResources(ServerToolStripMenuItem, "ServerToolStripMenuItem");
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(AboutToolStripMenuItem, "AboutToolStripMenuItem");
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(RemoveTimestamps);
            Controls.Add(Version);
            Controls.Add(PathLabel);
            Controls.Add(Parse);
            Controls.Add(SaveParsed);
            Controls.Add(CopyParsedToClipboard);
            Controls.Add(Parsed);
            Controls.Add(Browse);
            Controls.Add(DirectoryPath);
            Controls.Add(MenuStrip);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MainMenuStrip = MenuStrip;
            MaximizeBox = false;
            Name = "Main";
            FormClosing += Main_FormClosing;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RichTextBox DirectoryPath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.RichTextBox Parsed;
        private System.Windows.Forms.Button CopyParsedToClipboard;
        private System.Windows.Forms.Button SaveParsed;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.CheckBox RemoveTimestamps;
        private System.Windows.Forms.FolderBrowserDialog DirectoryBrowserDialog;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

