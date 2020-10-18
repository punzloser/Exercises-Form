using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        HoaDon hd = new HoaDon();
        
        public Form1()
        {
            InitializeComponent();
        }

    

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTiep.Enabled = false;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            btnTiep.Enabled = false;
            btnTinh.Enabled = true;
            txtDongia.Clear();
            txtSoluong.Clear();
            txtTenhang.Clear();
            txtThanhtien.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            btnTinh.Enabled = false;
            btnTiep.Enabled = true;
             hd.Tenhang = txtTenhang.Text ;
            hd.Soluong=int.Parse(txtSoluong.Text) ;
             hd.Dongia= float.Parse(txtDongia.Text);
            txtThanhtien.Text = hd.Tinh().ToString();
            
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            btnTinh.Enabled = true;
            btnTiep.Enabled = false;
            txtDongia.Clear();
            txtSoluong.Clear();
            txtTenhang.Clear();
            txtThanhtien.Clear();

            txtSohdban.Text = HoaDon.Sohd.ToString();
            txtTong.Text = HoaDon.Doanhthu.ToString();


        }
    }
}
