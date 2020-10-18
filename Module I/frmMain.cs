using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Module_I
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1 a = new Task1();
            a.MdiParent = this;
            a.Show();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2 a = new Task2();
            a.MdiParent = this;
            a.Show();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3 a = new Task3();
            a.MdiParent = this;
            a.Show();
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task5 a = new Task5();
            a.MdiParent = this;
            a.Show();
        }

        private void task6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task6 a = new Task6();
            a.MdiParent = this;
            a.Show();
        }
    }
}
