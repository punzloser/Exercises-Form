using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        private bool closeFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProvider1.SetError(txtUser, "Please enter your user name!");
            }
            else if (txtUser.Text.Contains(" "))
            {
                errorProvider1.SetError(txtUser, "Please do not enter white space!");
                e.Cancel = true;
                txtUser.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUser, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Please enter your password!");
                e.Cancel = true;
                txtPass.Focus();
            }
            else if (txtPass.Text.Contains(" "))
            {
                errorProvider1.SetError(txtPass, "Please do not enter white space!");
                e.Cancel = true;
                txtPass.Focus();
            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtPass, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Login successful!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeFlag = true;
            e.Cancel = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
