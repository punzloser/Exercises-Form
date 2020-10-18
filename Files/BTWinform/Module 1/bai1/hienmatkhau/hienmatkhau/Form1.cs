using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hienmatkhau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_pw.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            txt_show.Text = txt_pw.Text;

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            txt_show.Text = "";
            txt_pw.Clear();
            txt_pw.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
