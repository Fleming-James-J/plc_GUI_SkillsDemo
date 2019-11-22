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
    public partial class Calculator : Form
    {
        //Global Variables
        double FrstNum = 0.0;
        double ScndNum = 0.0;
        string Oprtr = "";


        public Calculator()
        {
            InitializeComponent();
        }
        // display
        private void Display_TextChanged(object sender, EventArgs e)
        {
            //the text box displays a zero unless a value is entered
            if (Display.Text.Length == 0)
            {
                Display.Text = "0";
            }
        }
        // NumPad numbers 0-9
        private void ZeroButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "0");
            Display.Text = tempNum.ToString();
        }

        private void OneButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "1");
            Display.Text = tempNum.ToString();
        }

        private void TwoButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "2");
            Display.Text = tempNum.ToString();
        }

        private void threeButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "3");
            Display.Text = tempNum.ToString();
        }

        private void fourButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "4");
            Display.Text = tempNum.ToString();
        }

        private void fiveButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "5");
            Display.Text = tempNum.ToString();
        }

        private void sixButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "6");
            Display.Text = tempNum.ToString();
        }

        private void sevenButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "7");
            Display.Text = tempNum.ToString();
        }

        private void eightButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "8");
            Display.Text = tempNum.ToString();
        }

        private void nineButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text + "9");
            Display.Text = tempNum.ToString();
        }
        
        //Modifier Buttons
        private void plusMinusButt_Click(object sender, EventArgs e)
        {
            double tempNum = Convert.ToDouble(Display.Text);
            tempNum = tempNum * (-1.0);
            Display.Text = tempNum.ToString();
        }

        private void decimalButt_Click(object sender, EventArgs e)
        {
            if (Display.Text.Contains(".") == false)
            {
                Display.Text = Display.Text + ".";
            }
        }

        //Operators

        private void plusButt_Click(object sender, EventArgs e)
        {
            FrstNum = Convert.ToDouble(Display.Text);
            Display.Clear();
            Oprtr = "+";
        }

        private void minusButt_Click(object sender, EventArgs e)
        {
            FrstNum = Convert.ToDouble(Display.Text);
            Display.Clear();
            Oprtr = "-";
        }

        private void multiButt_Click(object sender, EventArgs e)
        {
            FrstNum = Convert.ToDouble(Display.Text);
            Display.Clear();
            Oprtr = "*";
        }

        private void divButt_Click(object sender, EventArgs e)
        {
            FrstNum = Convert.ToDouble(Display.Text);
            Display.Clear();
            Oprtr = "/";
        }
        //Deleting
        private void delButt_Click(object sender, EventArgs e)
        {
            string tempStr = Display.Text;

            if(tempStr.Length > 0)
            {
                tempStr = tempStr.Substring(0, (tempStr.Length - 1));
                Display.Text = tempStr;
            }
        }
        //Doing the sums
        private void equalsButt_Click(object sender, EventArgs e)
        {
            ScndNum = Convert.ToDouble(Display.Text);
            Display.Clear();

            if (Oprtr == "+")
            {
                Display.Text = (FrstNum + ScndNum).ToString();
            }

            else if (Oprtr == "-")
            {
                Display.Text = (FrstNum - ScndNum).ToString();
            }

            else if (Oprtr == "*")
            {
                Display.Text = (FrstNum * ScndNum).ToString();
            }

            else if (Oprtr == "/")
            {
                Display.Text = (FrstNum / ScndNum).ToString();
            }
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
