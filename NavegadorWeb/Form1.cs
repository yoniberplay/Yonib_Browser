using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "google.com.do";
            webBrowser1.Navigate("google.com.do");
            


        }

        private void btnforward_Click(object sender, EventArgs e)
        {

            webBrowser1.GoForward();
            
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = this.webBrowser1.Url.ToString();
        }
    }
}
