﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        private const string info = "Web Browser v0.1.0.3 alpha build 25";
        const string messageAbout = info;
        const string messageAboutTitle = "About Web Browser";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageAboutButtons = MessageBoxButtons.OK;

            MessageBox.Show(messageAbout, messageAboutTitle, messageAboutButtons);
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            //toolStripProgressBar1.Visible = true;
            //toolStripProgressBar1.Value = 1;
        }

        private void caretBrowsingtF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageAboutButtons = MessageBoxButtons.OK;

            MessageBox.Show(messageAbout, messageAboutTitle, messageAboutButtons);
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        /*
private void toolStripProgressBar1_Click(object sender, EventHandler e)
{
toolStripProgressBar1.Visible = true;
//toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
//toolStripProgressBar1.Value = (int)e.CurrentProgress;
}*/
    }
}
