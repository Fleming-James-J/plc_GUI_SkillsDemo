namespace Skills_Demo
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Display = new System.Windows.Forms.TextBox();
            this.ZeroButt = new System.Windows.Forms.Button();
            this.OneButt = new System.Windows.Forms.Button();
            this.TwoButt = new System.Windows.Forms.Button();
            this.threeButt = new System.Windows.Forms.Button();
            this.fourButt = new System.Windows.Forms.Button();
            this.fiveButt = new System.Windows.Forms.Button();
            this.sixButt = new System.Windows.Forms.Button();
            this.sevenButt = new System.Windows.Forms.Button();
            this.eightButt = new System.Windows.Forms.Button();
            this.nineButt = new System.Windows.Forms.Button();
            this.plusButt = new System.Windows.Forms.Button();
            this.minusButt = new System.Windows.Forms.Button();
            this.multiButt = new System.Windows.Forms.Button();
            this.divButt = new System.Windows.Forms.Button();
            this.equalsButt = new System.Windows.Forms.Button();
            this.plusMinusButt = new System.Windows.Forms.Button();
            this.decimalButt = new System.Windows.Forms.Button();
            this.delButt = new System.Windows.Forms.Button();
            this.clearButt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(24, 54);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(349, 30);
            this.Display.TabIndex = 0;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // ZeroButt
            // 
            this.ZeroButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButt.Location = new System.Drawing.Point(121, 280);
            this.ZeroButt.Name = "ZeroButt";
            this.ZeroButt.Size = new System.Drawing.Size(91, 42);
            this.ZeroButt.TabIndex = 1;
            this.ZeroButt.Text = "0";
            this.ZeroButt.UseVisualStyleBackColor = true;
            this.ZeroButt.Click += new System.EventHandler(this.ZeroButt_Click);
            // 
            // OneButt
            // 
            this.OneButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButt.Location = new System.Drawing.Point(24, 218);
            this.OneButt.Name = "OneButt";
            this.OneButt.Size = new System.Drawing.Size(91, 42);
            this.OneButt.TabIndex = 2;
            this.OneButt.Text = "1";
            this.OneButt.UseVisualStyleBackColor = true;
            this.OneButt.Click += new System.EventHandler(this.OneButt_Click);
            // 
            // TwoButt
            // 
            this.TwoButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButt.Location = new System.Drawing.Point(121, 218);
            this.TwoButt.Name = "TwoButt";
            this.TwoButt.Size = new System.Drawing.Size(91, 42);
            this.TwoButt.TabIndex = 3;
            this.TwoButt.Text = "2";
            this.TwoButt.UseVisualStyleBackColor = true;
            this.TwoButt.Click += new System.EventHandler(this.TwoButt_Click);
            // 
            // threeButt
            // 
            this.threeButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButt.Location = new System.Drawing.Point(218, 218);
            this.threeButt.Name = "threeButt";
            this.threeButt.Size = new System.Drawing.Size(96, 42);
            this.threeButt.TabIndex = 4;
            this.threeButt.Text = "3";
            this.threeButt.UseVisualStyleBackColor = true;
            this.threeButt.Click += new System.EventHandler(this.threeButt_Click);
            // 
            // fourButt
            // 
            this.fourButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButt.Location = new System.Drawing.Point(24, 163);
            this.fourButt.Name = "fourButt";
            this.fourButt.Size = new System.Drawing.Size(91, 42);
            this.fourButt.TabIndex = 5;
            this.fourButt.Text = "4";
            this.fourButt.UseVisualStyleBackColor = true;
            this.fourButt.Click += new System.EventHandler(this.fourButt_Click);
            // 
            // fiveButt
            // 
            this.fiveButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButt.Location = new System.Drawing.Point(121, 163);
            this.fiveButt.Name = "fiveButt";
            this.fiveButt.Size = new System.Drawing.Size(91, 42);
            this.fiveButt.TabIndex = 6;
            this.fiveButt.Text = "5";
            this.fiveButt.UseVisualStyleBackColor = true;
            this.fiveButt.Click += new System.EventHandler(this.fiveButt_Click);
            // 
            // sixButt
            // 
            this.sixButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButt.Location = new System.Drawing.Point(218, 163);
            this.sixButt.Name = "sixButt";
            this.sixButt.Size = new System.Drawing.Size(96, 42);
            this.sixButt.TabIndex = 7;
            this.sixButt.Text = "6";
            this.sixButt.UseVisualStyleBackColor = true;
            this.sixButt.Click += new System.EventHandler(this.sixButt_Click);
            // 
            // sevenButt
            // 
            this.sevenButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButt.Location = new System.Drawing.Point(24, 101);
            this.sevenButt.Name = "sevenButt";
            this.sevenButt.Size = new System.Drawing.Size(91, 42);
            this.sevenButt.TabIndex = 8;
            this.sevenButt.Text = "7";
            this.sevenButt.UseVisualStyleBackColor = true;
            this.sevenButt.Click += new System.EventHandler(this.sevenButt_Click);
            // 
            // eightButt
            // 
            this.eightButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButt.Location = new System.Drawing.Point(121, 101);
            this.eightButt.Name = "eightButt";
            this.eightButt.Size = new System.Drawing.Size(91, 42);
            this.eightButt.TabIndex = 9;
            this.eightButt.Text = "8";
            this.eightButt.UseVisualStyleBackColor = true;
            this.eightButt.Click += new System.EventHandler(this.eightButt_Click);
            // 
            // nineButt
            // 
            this.nineButt.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButt.Location = new System.Drawing.Point(218, 101);
            this.nineButt.Name = "nineButt";
            this.nineButt.Size = new System.Drawing.Size(96, 42);
            this.nineButt.TabIndex = 10;
            this.nineButt.Text = "9";
            this.nineButt.UseVisualStyleBackColor = true;
            this.nineButt.Click += new System.EventHandler(this.nineButt_Click);
            // 
            // plusButt
            // 
            this.plusButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButt.Location = new System.Drawing.Point(324, 280);
            this.plusButt.Name = "plusButt";
            this.plusButt.Size = new System.Drawing.Size(49, 42);
            this.plusButt.TabIndex = 11;
            this.plusButt.Text = "+";
            this.plusButt.UseVisualStyleBackColor = true;
            this.plusButt.Click += new System.EventHandler(this.plusButt_Click);
            // 
            // minusButt
            // 
            this.minusButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButt.Location = new System.Drawing.Point(324, 220);
            this.minusButt.Name = "minusButt";
            this.minusButt.Size = new System.Drawing.Size(49, 42);
            this.minusButt.TabIndex = 12;
            this.minusButt.Text = "---";
            this.minusButt.UseVisualStyleBackColor = true;
            this.minusButt.Click += new System.EventHandler(this.minusButt_Click);
            // 
            // multiButt
            // 
            this.multiButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiButt.Location = new System.Drawing.Point(324, 163);
            this.multiButt.Name = "multiButt";
            this.multiButt.Size = new System.Drawing.Size(49, 42);
            this.multiButt.TabIndex = 13;
            this.multiButt.Text = "x";
            this.multiButt.UseVisualStyleBackColor = true;
            this.multiButt.Click += new System.EventHandler(this.multiButt_Click);
            // 
            // divButt
            // 
            this.divButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButt.Location = new System.Drawing.Point(324, 101);
            this.divButt.Name = "divButt";
            this.divButt.Size = new System.Drawing.Size(49, 42);
            this.divButt.TabIndex = 14;
            this.divButt.Text = "/";
            this.divButt.UseVisualStyleBackColor = true;
            this.divButt.Click += new System.EventHandler(this.divButt_Click);
            // 
            // equalsButt
            // 
            this.equalsButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButt.Location = new System.Drawing.Point(218, 341);
            this.equalsButt.Name = "equalsButt";
            this.equalsButt.Size = new System.Drawing.Size(155, 42);
            this.equalsButt.TabIndex = 15;
            this.equalsButt.Text = "=";
            this.equalsButt.UseVisualStyleBackColor = true;
            this.equalsButt.Click += new System.EventHandler(this.equalsButt_Click);
            // 
            // plusMinusButt
            // 
            this.plusMinusButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinusButt.Location = new System.Drawing.Point(24, 280);
            this.plusMinusButt.Name = "plusMinusButt";
            this.plusMinusButt.Size = new System.Drawing.Size(91, 42);
            this.plusMinusButt.TabIndex = 16;
            this.plusMinusButt.Text = "+/-";
            this.plusMinusButt.UseVisualStyleBackColor = true;
            this.plusMinusButt.Click += new System.EventHandler(this.plusMinusButt_Click);
            // 
            // decimalButt
            // 
            this.decimalButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButt.Location = new System.Drawing.Point(218, 282);
            this.decimalButt.Name = "decimalButt";
            this.decimalButt.Size = new System.Drawing.Size(96, 42);
            this.decimalButt.TabIndex = 17;
            this.decimalButt.Text = ".";
            this.decimalButt.UseVisualStyleBackColor = true;
            this.decimalButt.Click += new System.EventHandler(this.decimalButt_Click);
            // 
            // delButt
            // 
            this.delButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButt.Location = new System.Drawing.Point(24, 341);
            this.delButt.Name = "delButt";
            this.delButt.Size = new System.Drawing.Size(91, 42);
            this.delButt.TabIndex = 18;
            this.delButt.Text = "Backspace";
            this.delButt.UseVisualStyleBackColor = true;
            this.delButt.Click += new System.EventHandler(this.delButt_Click);
            // 
            // clearButt
            // 
            this.clearButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButt.Location = new System.Drawing.Point(121, 341);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(91, 42);
            this.clearButt.TabIndex = 19;
            this.clearButt.Text = "Clear";
            this.clearButt.UseVisualStyleBackColor = true;
            this.clearButt.Click += new System.EventHandler(this.clearButt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 30);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 412);
            this.Controls.Add(this.clearButt);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.decimalButt);
            this.Controls.Add(this.plusMinusButt);
            this.Controls.Add(this.equalsButt);
            this.Controls.Add(this.divButt);
            this.Controls.Add(this.multiButt);
            this.Controls.Add(this.minusButt);
            this.Controls.Add(this.plusButt);
            this.Controls.Add(this.nineButt);
            this.Controls.Add(this.eightButt);
            this.Controls.Add(this.sevenButt);
            this.Controls.Add(this.sixButt);
            this.Controls.Add(this.fiveButt);
            this.Controls.Add(this.fourButt);
            this.Controls.Add(this.threeButt);
            this.Controls.Add(this.TwoButt);
            this.Controls.Add(this.OneButt);
            this.Controls.Add(this.ZeroButt);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button ZeroButt;
        private System.Windows.Forms.Button OneButt;
        private System.Windows.Forms.Button TwoButt;
        private System.Windows.Forms.Button threeButt;
        private System.Windows.Forms.Button fourButt;
        private System.Windows.Forms.Button fiveButt;
        private System.Windows.Forms.Button sixButt;
        private System.Windows.Forms.Button sevenButt;
        private System.Windows.Forms.Button eightButt;
        private System.Windows.Forms.Button nineButt;
        private System.Windows.Forms.Button plusButt;
        private System.Windows.Forms.Button minusButt;
        private System.Windows.Forms.Button multiButt;
        private System.Windows.Forms.Button divButt;
        private System.Windows.Forms.Button equalsButt;
        private System.Windows.Forms.Button plusMinusButt;
        private System.Windows.Forms.Button decimalButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}