using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Module_III
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void txtSoChia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoChia.Text)) 
            {
                e.Cancel = true;
                txtSoChia.Focus();
                //errorProvider1.SetError(txtSoChia, "Vui lòng không bỏ trống ! ");
                MessageBox.Show("Vui lòng không bỏ trống ! ", "Lỗi");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoChia, null);
            }
        }

        private void txtSoChia_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoChia.Text, "[^0-9]+"))
            {
                errorProvider1.SetError(txtSoChia, "Nhập số và không được nhỏ hơn 0");
                MessageBox.Show("Nhập số và không được nhỏ hơn 0", "Lỗi");
                txtSoChia.Clear();
                txtSoChia.Focus();
            }
        }

        private void txtSoBiChia_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoBiChia.Text, "[^0-9]+"))
            {
                errorProvider1.SetError(txtSoBiChia, "Nhập số và không được nhỏ hơn 0");
                MessageBox.Show("Nhập số và không được nhỏ hơn 0", "Lỗi");
                txtSoBiChia.Clear();
                txtSoBiChia.Focus();
            }
            else if (txtSoBiChia.Text == "0")
            {
                errorProvider1.SetError(txtSoBiChia, "Lỗi chia cho 0");
                MessageBox.Show("Lỗi chia cho 0", "Lỗi");
                txtSoBiChia.Clear();
                txtSoBiChia.Focus();
            }
        }

        private void txtSoBiChia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoBiChia.Text))
            {
                e.Cancel = true;
                txtSoChia.Focus();
                errorProvider1.SetError(txtSoBiChia, "Vui lòng không bỏ trống");
                MessageBox.Show("Vui lòng không bỏ trống", "Lỗi");

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoBiChia, null);
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            float SoChia, SoBiChia;
            SoChia = float.Parse(txtSoChia.Text);
            SoBiChia = float.Parse(txtSoBiChia.Text);

            if (SoChia < 0 || SoBiChia < 0)
            {
                throw new IndexOutOfRangeException("Vui lòng nhập số lớn hơn 0");
            }
            if (SoBiChia == 0)
            {
                throw new IndexOutOfRangeException("Lỗi chia cho 0");
            }

            txtKetQua.Text = (SoChia / SoBiChia).ToString();    
        }
    }
}
