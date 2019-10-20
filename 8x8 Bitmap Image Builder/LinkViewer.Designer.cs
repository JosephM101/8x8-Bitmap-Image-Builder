namespace _8x8_Bitmap_Image_Builder
{
    partial class LinkViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInDefaultWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyCurrentPageLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyExecutedPageLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.browserOptionsToolStripMenuItem,
            this.openInDefaultWebBrowserToolStripMenuItem,
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openInDefaultWebBrowserToolStripMenuItem
            // 
            this.openInDefaultWebBrowserToolStripMenuItem.Name = "openInDefaultWebBrowserToolStripMenuItem";
            this.openInDefaultWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.openInDefaultWebBrowserToolStripMenuItem.Text = "Open in Default Web Browser";
            this.openInDefaultWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.openInDefaultWebBrowserToolStripMenuItem_Click);
            // 
            // browserOptionsToolStripMenuItem
            // 
            this.browserOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshPageToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyCurrentPageLinkToolStripMenuItem,
            this.copyExecutedPageLinkToolStripMenuItem});
            this.browserOptionsToolStripMenuItem.Name = "browserOptionsToolStripMenuItem";
            this.browserOptionsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.browserOptionsToolStripMenuItem.Text = "Browser &Options";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // refreshPageToolStripMenuItem
            // 
            this.refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            this.refreshPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.refreshPageToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.refreshPageToolStripMenuItem.Text = "Refresh Page";
            this.refreshPageToolStripMenuItem.ToolTipText = "Refreshes the current page";
            this.refreshPageToolStripMenuItem.Click += new System.EventHandler(this.refreshPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // copyCurrentPageLinkToolStripMenuItem
            // 
            this.copyCurrentPageLinkToolStripMenuItem.Name = "copyCurrentPageLinkToolStripMenuItem";
            this.copyCurrentPageLinkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.copyCurrentPageLinkToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copyCurrentPageLinkToolStripMenuItem.Text = "Copy Current Page Link";
            this.copyCurrentPageLinkToolStripMenuItem.ToolTipText = "Copies the link of the current page to the clipboard";
            this.copyCurrentPageLinkToolStripMenuItem.Click += new System.EventHandler(this.copyCurrentPageLinkToolStripMenuItem_Click);
            // 
            // copyExecutedPageLinkToolStripMenuItem
            // 
            this.copyExecutedPageLinkToolStripMenuItem.Name = "copyExecutedPageLinkToolStripMenuItem";
            this.copyExecutedPageLinkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.copyExecutedPageLinkToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copyExecutedPageLinkToolStripMenuItem.Text = "Copy Executed Page Link";
            this.copyExecutedPageLinkToolStripMenuItem.ToolTipText = "Copies the first link opened to the clipboard";
            this.copyExecutedPageLinkToolStripMenuItem.Click += new System.EventHandler(this.copyExecutedPageLinkToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(706, 335);
            this.webBrowser1.TabIndex = 1;
            // 
            // openCurrentLinkInDefaultWebBrowserToolStripMenuItem
            // 
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem.Name = "openCurrentLinkInDefaultWebBrowserToolStripMenuItem";
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(246, 20);
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem.Text = "Open Current Page in Default Web Browser";
            this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.openCurrentLinkInDefaultWebBrowserToolStripMenuItem_Click);
            // 
            // LinkViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 359);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LinkViewer";
            this.ShowIcon = false;
            this.Text = "Link Viewer";
            this.Load += new System.EventHandler(this.LinkViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInDefaultWebBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCurrentPageLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyExecutedPageLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openCurrentLinkInDefaultWebBrowserToolStripMenuItem;
    }
}