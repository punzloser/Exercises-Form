using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrstName_Click(object sender, EventArgs e)
        {
            lblName.Text = txtFrstName.Text;
        }

        private void btnLstName_Click(object sender, EventArgs e)
        {
            lblName.Text = txtLstName.Text;
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            lblName.Text = txtFrstName.Text + " " + txtLstName.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void lblName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblName.Text = "";
        }
    }
}
