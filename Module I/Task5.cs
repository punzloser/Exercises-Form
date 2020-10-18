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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Red;
            lblCodeBy.ForeColor = Color.Red;
        }
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblCodeBy.Text = txtNhapTen.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtNhapTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Green;
            lblCodeBy.ForeColor = Color.Green;
        }
        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Blue;
            lblCodeBy.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Black;
            lblCodeBy.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size,txtNhapTen.Font.Style ^ FontStyle.Bold);
            lblCodeBy.Font = new Font(lblCodeBy.Font.Name, lblCodeBy.Font.Size, lblCodeBy.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Italic);
            lblCodeBy.Font = new Font(lblCodeBy.Font.Name, lblCodeBy.Font.Size, lblCodeBy.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, txtNhapTen.Font.Style ^ FontStyle.Underline);
            lblCodeBy.Font = new Font(lblCodeBy.Font.Name, lblCodeBy.Font.Size, lblCodeBy.Font.Style ^ FontStyle.Underline);
        }
    }
}
