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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            txtSL.Clear();
            txtDG.Clear();
            txtTT.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int intSoluong;
            decimal decDonGia, decThanhTien;
            if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
            }
            else if (txtDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!");
            }
            else
            {
                intSoluong = Convert.ToInt32(txtSL.Text);
                decDonGia = Convert.ToDecimal(txtDG.Text);
                if (intSoluong < 0)
                {
                    MessageBox.Show("Số lượng phải > 0.");
                    txtSL.SelectAll();
                    txtSL.Focus();
                }
                else if (decDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá > 0");
                    txtDG.SelectAll();
                    txtDG.Focus();
                }
                else
                {
                    decThanhTien = intSoluong * decDonGia;
                    txtTT.Text = decThanhTien.ToString();
                }
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
