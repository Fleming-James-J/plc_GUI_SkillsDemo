using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //mistakenly clicked
        }
        //setting the buttons and menu selection for each application
        private void NotepadButt_Click(object sender, EventArgs e)
        {
            Notepad notepadOpen = new Notepad();
            notepadOpen.ShowDialog();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad notepadOpen = new Notepad();
            notepadOpen.ShowDialog();
        }

        private void CalcButt_Click(object sender, EventArgs e)
        {
            Calculator calcOpen = new Calculator();
            calcOpen.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calcOpen = new Calculator();
            calcOpen.ShowDialog();
        }

        private void PicViewButt_Click(object sender, EventArgs e)
        {
            PictureViewer Pviewer = new PictureViewer();
            Pviewer.ShowDialog();
        }

        private void pictureViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureViewer Pviewer = new PictureViewer();
            Pviewer.ShowDialog();
        }

        private void WebBrowserButt_Click(object sender, EventArgs e)
        {
            WebBrowser Wbrowser = new WebBrowser();
            Wbrowser.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser Wbrowser = new WebBrowser();
            Wbrowser.ShowDialog();
        }

        private void ProjectButt_Click(object sender, EventArgs e)
        {
            ModelDatabase mDatabase = new ModelDatabase();
            mDatabase.ShowDialog();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelDatabase mDatabase = new ModelDatabase();
            mDatabase.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void AboutButt_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        //closes the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Background Colours
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
        //Label Fonts
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainScreenLabel.Font = new Font("Times New Roman", mainScreenLabel.Font.Size);
        }

        private void calibiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainScreenLabel.Font = new Font("Calibri", mainScreenLabel.Font.Size);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainScreenLabel.Font = new Font("Arial", mainScreenLabel.Font.Size);
        }

        
    }
}
