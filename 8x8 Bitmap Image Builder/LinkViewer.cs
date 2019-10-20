using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8x8_Bitmap_Image_Builder
{
    public partial class LinkViewer : Form
    {
        public string link = "";
        public LinkViewer(string ln)
        {
            link = ln;
            InitializeComponent();
            webBrowser1.Url = new Uri(ln);
            
        }

        private void LinkViewer_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openInDefaultWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(link);
            Close();
        }

        private void refreshPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void copyCurrentPageLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(webBrowser1.Url.AbsoluteUri);
        }

        private void copyExecutedPageLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(link);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void defaultWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openCurrentLinkInDefaultWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(webBrowser1.Url.AbsoluteUri);
            Close();
        }
    }
}
