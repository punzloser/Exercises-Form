using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_holot_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_holot.Text;
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_ten.Text;
        }

        private void btn_hoten_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_holot.Text + " " + txt_ten.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_hoten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_hoten_DoubleClick(object sender, EventArgs e)
        {
            lbl_hoten.Text = "";
        }

        private void lbl_hoten_DoubleClick(object sender, EventArgs e)
        {
            lbl_hoten.Text = "";
        }
    }
}
