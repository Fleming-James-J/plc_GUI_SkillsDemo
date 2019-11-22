using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;


namespace Skills_Demo
{
    public partial class Notepad : Form
    {
        //place to store file name for saving 
        string CurrentFilesName = "";


        public Notepad()
        {
            InitializeComponent();
        }

        //Global variables 
        Color[] ColourChoices;

        private void FontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changing the font size

            int newFontSize = Convert.ToInt32(FontSizeCombo.Text);
            NotepadText.Font = new Font(NotepadText.Font.FontFamily, newFontSize);
        }

        private void FontCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changing the font
            NotepadText.Font = new Font(FontCombo.Text, NotepadText.Font.Size);
        }

        private void TColourCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            NotepadText.ForeColor = ColourChoices[TColourCombo.SelectedIndex];

        }

        private void BGColourCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackColor = ColourChoices[BGColourCombo.SelectedIndex];
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            //setting the colour options when the notepad opens
            ColourChoices = new Color[5];
            ColourChoices[0] = Color.Black;
            ColourChoices[1] = Color.White;
            ColourChoices[2] = Color.Red;
            ColourChoices[3] = Color.Blue;
            ColourChoices[4] = Color.Yellow;

            //setting the text and background colours defaults on opening
            FontCombo.SelectedIndex = 0;
            FontSizeCombo.SelectedIndex = 3;
            BGColourCombo.SelectedIndex = 1;
            TColourCombo.SelectedIndex = 0;


        }

        private void saveAS()
        {//creating a save file dialog box
            SaveFileDialog saveAsBox = new SaveFileDialog();
            saveAsBox.Filter = "A text file|*.txt |MS Word |*.doc";

            if (saveAsBox.ShowDialog() == DialogResult.OK)
            {
                //opening the stream writer
                StreamWriter mySR = new StreamWriter(saveAsBox.FileName);

                //write into file 
                mySR.Write(NotepadText.Text);

                //closing the stream
                mySR.Close();

                //disposing of the stream
                mySR.Dispose();

                //updating the filepath
                CurrentFilesName = saveAsBox.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opening open file dialog box
            OpenFileDialog openMyFile = new OpenFileDialog();
            openMyFile.Filter = "A text file|*.txt |MS Word |*.doc";

            if (openMyFile.ShowDialog() == DialogResult.OK)
            {
                //opening a stream reader
                StreamReader readIn = new StreamReader(openMyFile.FileName);

                //reading the stream
                NotepadText.Text = readIn.ReadToEnd();

                //closing the stream
                readIn.Close();

                //disposing the stream
                readIn.Dispose();


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrentFilesName.Length == 0)
            {
                saveAS();
            }
            else
            {
                //opening the stream
                StreamWriter mySR = new StreamWriter(CurrentFilesName);

                //write into file
                mySR.Write(NotepadText.Text);

                //closing the stream
                mySR.Close();

                //dispose of the stream
                mySR.Dispose();
                
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAS();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
