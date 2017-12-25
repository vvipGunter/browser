using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bros1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.GoHome();
            
        }
        
        

        private void toolStripButton3_Click(object sender, EventArgs e)     //跳转
        {
            webBrowser1.Navigate(toolStripComboBox1.Text);
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)    //主页
        {
            this.webBrowser1.GoHome();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)    //后退
        {
            this.webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)    //前进
        {
           this. webBrowser1.GoForward();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
         }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

      

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "网页加载完成！";
            toolStripProgressBar1.Visible = false;
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripStatusLabel1.Text = "正在加载网页";
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (webBrowser1.Document.ActiveElement!=null)
            {
                webBrowser1.Navigate(webBrowser1.Document.ActiveElement.GetAttribute("href"));
            }
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void 页面另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void internet选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process c = new System.Diagnostics.Process();
            c.StartInfo = new System.Diagnostics.ProcessStartInfo("rundll32.exe", "shell32.dll,Control_RunDLL inetcpl.cpl");
            c.Start();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void 打印预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (statusStrip1.Width > 300)
                toolStripComboBox1.Width = statusStrip1.Width - 200;
            else if (statusStrip1.Width < 300)
                toolStripComboBox1.Width = statusStrip1.Width - 50;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            toolStripStatusLabel1.Text = "正在加载网页";
        }
    }
}
