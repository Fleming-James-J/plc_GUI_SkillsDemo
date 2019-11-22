namespace Skills_Demo
{
    partial class WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            this.homePanel = new System.Windows.Forms.Panel();
            this.forwardPanel = new System.Windows.Forms.Panel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.cancelPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.refreshPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webExitButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePanel.BackgroundImage")));
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Location = new System.Drawing.Point(19, 23);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(35, 36);
            this.homePanel.TabIndex = 0;
            this.homePanel.Click += new System.EventHandler(this.homePanel_Click);
            // 
            // forwardPanel
            // 
            this.forwardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardPanel.BackgroundImage")));
            this.forwardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardPanel.Location = new System.Drawing.Point(136, 23);
            this.forwardPanel.Name = "forwardPanel";
            this.forwardPanel.Size = new System.Drawing.Size(35, 36);
            this.forwardPanel.TabIndex = 1;
            this.forwardPanel.Click += new System.EventHandler(this.forwardPanel_Click);
            // 
            // backPanel
            // 
            this.backPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backPanel.BackgroundImage")));
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Location = new System.Drawing.Point(79, 23);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(35, 36);
            this.backPanel.TabIndex = 1;
            this.backPanel.Click += new System.EventHandler(this.backPanel_Click);
            // 
            // cancelPanel
            // 
            this.cancelPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelPanel.BackgroundImage")));
            this.cancelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPanel.Location = new System.Drawing.Point(193, 23);
            this.cancelPanel.Name = "cancelPanel";
            this.cancelPanel.Size = new System.Drawing.Size(35, 36);
            this.cancelPanel.TabIndex = 1;
            this.cancelPanel.Click += new System.EventHandler(this.cancelPanel_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPanel.BackgroundImage")));
            this.searchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchPanel.Location = new System.Drawing.Point(676, 23);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(35, 36);
            this.searchPanel.TabIndex = 1;
            this.searchPanel.Click += new System.EventHandler(this.searchPanel_Click);
            // 
            // refreshPanel
            // 
            this.refreshPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshPanel.BackgroundImage")));
            this.refreshPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshPanel.Location = new System.Drawing.Point(734, 23);
            this.refreshPanel.Name = "refreshPanel";
            this.refreshPanel.Size = new System.Drawing.Size(35, 36);
            this.refreshPanel.TabIndex = 1;
            this.refreshPanel.Click += new System.EventHandler(this.refreshPanel_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(247, 33);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(414, 26);
            this.searchBox.TabIndex = 2;
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBox_MouseClick);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 70);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1261, 567);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // webExitButt
            // 
            this.webExitButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.webExitButt.Location = new System.Drawing.Point(1084, 25);
            this.webExitButt.Name = "webExitButt";
            this.webExitButt.Size = new System.Drawing.Size(134, 33);
            this.webExitButt.TabIndex = 4;
            this.webExitButt.Text = "Exit";
            this.webExitButt.UseVisualStyleBackColor = true;
            this.webExitButt.Click += new System.EventHandler(this.webExitButt_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 617);
            this.Controls.Add(this.webExitButt);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.refreshPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.cancelPanel);
            this.Controls.Add(this.forwardPanel);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.homePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebBrowser";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel forwardPanel;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel cancelPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel refreshPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button webExitButt;
    }
}