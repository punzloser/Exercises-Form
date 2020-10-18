using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        const int DonGia = 20000;
        int demKH = 0, demSV = 0;
        double DoanhThu= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có muốn đóng?",
                                  "warning",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int SoLuong;
            double ThanhTien;
            if (txtName.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên khách hàng!");
                txtName.Focus();
            }
            else if (!int.TryParse(txtSoluong.Text, out SoLuong))
            {
                MessageBox.Show("Số lượng phải > 0");
                txtSoluong.Clear();
                txtSoluong.Focus();
            }
            else
            {
                ThanhTien = SoLuong * DonGia;
                demKH++;
                if (ckbIsStudent.Checked == true)
                {
                    ThanhTien *= 0.95;
                    demSV++;
                }
                txtPrice.Text = ThanhTien.ToString();
                DoanhThu += ThanhTien;
            }
                
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSoluong.Clear();
            ckbIsStudent.Checked = false;
            txtPrice.Clear();
            txtName.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtDoanhThu.Text = DoanhThu.ToString();
            txtSoKH.Text = demKH.ToString();
            txtTongSV.Text = demSV.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
