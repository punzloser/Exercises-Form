using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clickme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2010 Programming!");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Form was clicked!");
        }
    }
}
