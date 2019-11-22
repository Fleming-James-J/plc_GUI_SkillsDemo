namespace Skills_Demo
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontCombo = new System.Windows.Forms.ComboBox();
            this.FontSizeCombo = new System.Windows.Forms.ComboBox();
            this.TColourCombo = new System.Windows.Forms.ComboBox();
            this.BGColourCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotepadText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveToolStripMenuItem.Text = "Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FontCombo
            // 
            this.FontCombo.FormattingEnabled = true;
            this.FontCombo.Items.AddRange(new object[] {
            "Times New Roman",
            "Arial",
            "Calibri"});
            this.FontCombo.Location = new System.Drawing.Point(12, 56);
            this.FontCombo.Name = "FontCombo";
            this.FontCombo.Size = new System.Drawing.Size(184, 30);
            this.FontCombo.TabIndex = 9;
            this.FontCombo.SelectedIndexChanged += new System.EventHandler(this.FontCombo_SelectedIndexChanged);
            // 
            // FontSizeCombo
            // 
            this.FontSizeCombo.FormattingEnabled = true;
            this.FontSizeCombo.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.FontSizeCombo.Location = new System.Drawing.Point(217, 56);
            this.FontSizeCombo.Name = "FontSizeCombo";
            this.FontSizeCombo.Size = new System.Drawing.Size(72, 30);
            this.FontSizeCombo.TabIndex = 2;
            this.FontSizeCombo.SelectedIndexChanged += new System.EventHandler(this.FontSizeCombo_SelectedIndexChanged);
            // 
            // TColourCombo
            // 
            this.TColourCombo.FormattingEnabled = true;
            this.TColourCombo.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Blue",
            "Yellow"});
            this.TColourCombo.Location = new System.Drawing.Point(328, 56);
            this.TColourCombo.Name = "TColourCombo";
            this.TColourCombo.Size = new System.Drawing.Size(121, 30);
            this.TColourCombo.TabIndex = 3;
            this.TColourCombo.SelectedIndexChanged += new System.EventHandler(this.TColourCombo_SelectedIndexChanged);
            // 
            // BGColourCombo
            // 
            this.BGColourCombo.FormattingEnabled = true;
            this.BGColourCombo.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Blue",
            "Yellow"});
            this.BGColourCombo.Location = new System.Drawing.Point(482, 56);
            this.BGColourCombo.Name = "BGColourCombo";
            this.BGColourCombo.Size = new System.Drawing.Size(121, 30);
            this.BGColourCombo.TabIndex = 4;
            this.BGColourCombo.SelectedIndexChanged += new System.EventHandler(this.BGColourCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Font Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Background Colour";
            // 
            // NotepadText
            // 
            this.NotepadText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadText.Location = new System.Drawing.Point(12, 103);
            this.NotepadText.Multiline = true;
            this.NotepadText.Name = "NotepadText";
            this.NotepadText.Size = new System.Drawing.Size(636, 471);
            this.NotepadText.TabIndex = 1;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 606);
            this.Controls.Add(this.NotepadText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGColourCombo);
            this.Controls.Add(this.TColourCombo);
            this.Controls.Add(this.FontSizeCombo);
            this.Controls.Add(this.FontCombo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ComboBox FontCombo;
        private System.Windows.Forms.ComboBox FontSizeCombo;
        private System.Windows.Forms.ComboBox TColourCombo;
        private System.Windows.Forms.ComboBox BGColourCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotepadText;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}