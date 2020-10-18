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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoten = txtTen.Text;
            string[] Arrayhoten = hoten.Split();
            lblHo.Text = Arrayhoten[0];
            lblTen.Text = Arrayhoten[Arrayhoten.Length - 1];
            lblChulot.Text = "";
            for (int i=0;i<Arrayhoten.Length;i++)
            {
                if (i != 0 && i != Arrayhoten.Length - 1)
                    lblChulot.Text += Arrayhoten[i] + " ";
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtTen.Focus();
            lblHo.Text = "";
            lblChulot.Text = "";
            lblTen.Text = "";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
           DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát!","Thông báo",MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                 this.Close();
            }
           
            
        }
    }
}
