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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
            txtName.Focus();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " " + txtMessage.Text;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblMessage.Text = txtName.Text + " " + txtMessage.Text;
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lblMessage.Text = txtName.Text + " " + txtMessage.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMessage.Clear();
            lblMessage.Text = "";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Red;
            txtMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Green;
            txtMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Blue;
            txtMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
            txtMessage.ForeColor = Color.Black;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.picBigBox2, "Click me !");
            toolTip1.SetToolTip(this.picSmallBox1, "click me !");
            lblMessage.Visible = false;
        }

        private void picSmallBox1_Click(object sender, EventArgs e)
        {
            picSmallBox1.Visible = false;
            picBigBox2.Visible = true;
        }

        private void picBigBox2_Click(object sender, EventArgs e)
        {
            picBigBox2.Visible = false;
            picSmallBox1.Visible = true;
        }
    }
}
