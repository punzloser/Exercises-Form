using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_I
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void bttDisplay_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = txtPassword.Text;
        }

        private void bttSkip_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            //txtPassword..Text = ""; same 
            lbDisplay.Text = "";
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
