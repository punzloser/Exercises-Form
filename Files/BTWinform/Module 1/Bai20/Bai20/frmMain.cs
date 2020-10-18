using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1.Form1 a = new Bai1.Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2.Form1 a = new Bai2.Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3.Form1 a = new Bai3.Form1();
            a.MdiParent = this;
            a.Show();
        }
    }
}
