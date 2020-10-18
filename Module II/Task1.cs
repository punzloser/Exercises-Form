using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_II
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenHang.Focus();
        }


        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            lbThanhTien.Text = "";
            txtTenHang.Focus();
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int intSoluong;
            decimal decDonGia, decThanhTien;
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!");
            }
            else
            {
                intSoluong = Convert.ToInt32(txtSoLuong.Text);
                decDonGia = Convert.ToDecimal(txtDonGia.Text);
                if (intSoluong < 0)
                {
                    MessageBox.Show("Số lượng phải > 0.");
                    txtSoLuong.SelectAll();
                    txtSoLuong.Focus();
                }
                else if (decDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá > 0");
                    txtDonGia.SelectAll();
                    txtDonGia.Focus();
                }
                else
                {
                    decThanhTien = intSoluong * decDonGia;
                    lbThanhTien.Text = decThanhTien.ToString();
                }
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult d1;
            d1 = MessageBox.Show("Bạn có muốn đóng ứng dụng", "warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d1 == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
        }
    }
}
