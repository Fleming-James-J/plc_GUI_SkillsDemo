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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.ie");
        }
        
        private void webSearch()
        {
            if (searchBox.Text.Contains(".") && !searchBox.Text.Contains(" "))
            {
                webBrowser1.Navigate(searchBox.Text);
            }
            else
            {
                webBrowser1.Navigate(@"https://www.google.ie/?gws_rd=cr,ssl&ei=4ZigWNanGOWOgAav7oPADA#safe=off&q=" + searchBox.Text);
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                webSearch();
                e.Handled = true;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            searchBox.Text = webBrowser1.Url.ToString();
        }

        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchBox.SelectAll();
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.ie");
        }

        private void backPanel_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardPanel_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void cancelPanel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void searchPanel_Click(object sender, EventArgs e)
        {
            webSearch();
        }

        private void refreshPanel_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webExitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
