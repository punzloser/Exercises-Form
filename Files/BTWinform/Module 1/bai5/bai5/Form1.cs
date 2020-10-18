using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtNhapten.Text;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
           
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
            
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;

        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Italic);

        }

        private void chkUnder_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Underline);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                // Call quit method.  
                this.Close();
            }

        }

        private void txtNhapten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
