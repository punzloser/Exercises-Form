using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void bttClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked !");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form2 Loaded !");
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form2 Cliked !");
        }
    }
}
