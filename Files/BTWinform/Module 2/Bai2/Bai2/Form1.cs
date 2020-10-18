using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        int intTongSoLuong = 0, dem = 0;
        decimal decTongTien = 0, decTrungBinh;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có muốn đóng?",
                                  "warning",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            txtDongia.Clear();
            txtSoluong.Clear();
            txtThanhtien.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int intSoluong;
            decimal decDonGia, decThanhTien;
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
            }
            else if (txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!");
            }
            else
            {
                intSoluong = Convert.ToInt32(txtSoluong.Text);
                decDonGia = Convert.ToDecimal(txtDongia.Text);
                if (intSoluong < 0)
                {
                    MessageBox.Show("Số lượng phải > 0.");
                    txtSoluong.SelectAll();
                    txtSoluong.Focus();
                }
                else if (decDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá > 0");
                    txtDongia.SelectAll();
                    txtDongia.Focus();
                }
                else
                {
                    dem++;
                    decThanhTien = intSoluong * decDonGia;
                    txtThanhtien.Text = decThanhTien.ToString();
                    intTongSoLuong += intSoluong;
                    decTongTien += decThanhTien;
                    decTrungBinh += decTongTien / dem;
                    txtTongSL.Text = intTongSoLuong.ToString();
                    txtTongTien.Text = decTongTien.ToString();
                    txtTrungbinh.Text = decTrungBinh.ToString();
                }
            }
        }
    }
}
