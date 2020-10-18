using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
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

        private void bnTinh_Click(object sender, EventArgs e)
        {
            btnTiep.Enabled = true;
            bnTinh.Enabled = false;
            if(rdDen.Checked==true)
            {
                hd.Mauxe = true;
                txtPhuthu.Text = hd.PhuThu().ToString();
                hd.Giatien = float.Parse(txtGiatien.Text);
                hd.Thue = float.Parse(txtThue.Text);
                txtThanhtien.Text = hd.thanhtien().ToString();
               
            }
            if(rdKhac.Checked ==true)
            {
                hd.Mauxe = false;
                txtPhuthu.Text = hd.PhuThu().ToString();
                hd.Giatien = float.Parse(txtGiatien.Text);
                hd.Thue = float.Parse(txtThue.Text);
                txtThanhtien.Text = hd.thanhtien().ToString();
               
            }

            

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            bnTinh.Enabled = true;
            btnTiep.Enabled = false;
            txtHoten.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtGiatien.Clear();
            txtPhuthu.Clear();
            txtThue.Clear();
            txtThanhtien.Clear();
            txtDoanhthu.Clear();
            txtTongkhach.Clear();
            txtTongkhachxeden.Clear();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            bnTinh.Enabled = true;
            btnTiep.Enabled = false;
            txtHoten.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtGiatien.Clear();
            txtPhuthu.Clear();
            txtThue.Clear();
            txtThanhtien.Clear();

            txtTongkhach.Text = HoaDon.Sokh.ToString();
            txtTongkhachxeden.Text = HoaDon.Sokhden.ToString();
            txtDoanhthu.Text = HoaDon.Doanhthu.ToString();
        }
    }
}
