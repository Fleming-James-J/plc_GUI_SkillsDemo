namespace Skills_Demo
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentIDlabel = new System.Windows.Forms.Label();
            this.returnButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(47, 34);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(324, 40);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Skills Demonstration";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(148, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(114, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "James Fleming";
            // 
            // studentIDlabel
            // 
            this.studentIDlabel.AutoSize = true;
            this.studentIDlabel.Location = new System.Drawing.Point(178, 119);
            this.studentIDlabel.Name = "studentIDlabel";
            this.studentIDlabel.Size = new System.Drawing.Size(58, 22);
            this.studentIDlabel.TabIndex = 2;
            this.studentIDlabel.Text = "CS-021";
            // 
            // returnButt
            // 
            this.returnButt.Location = new System.Drawing.Point(171, 144);
            this.returnButt.Name = "returnButt";
            this.returnButt.Size = new System.Drawing.Size(75, 41);
            this.returnButt.TabIndex = 3;
            this.returnButt.Text = "Return";
            this.returnButt.UseVisualStyleBackColor = true;
            this.returnButt.Click += new System.EventHandler(this.returnButt_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 197);
            this.Controls.Add(this.returnButt);
            this.Controls.Add(this.studentIDlabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.aboutLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label studentIDlabel;
        private System.Windows.Forms.Button returnButt;
    }
}