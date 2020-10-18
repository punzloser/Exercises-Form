using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        private bool closingFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {


            //try
            //{


            float miles, gallons;
            miles = float.Parse(txtMile.Text);
            gallons = float.Parse(txtGallon.Text);



            //    if (miles < 0)
            //        throw new IndexOutOfRangeException("Bạn đã nhập số âm! vui lòng nhập số lớn hơn 0!");

            //    if (gallons < 0)
            //        throw new IndexOutOfRangeException("Bạn đã nhập số âm! vui lòng nhập số lớn hơn 0!");
            //    if (gallons == 0)
            //        throw new IndexOutOfRangeException("Lỗi chia cho 0!");

            txtCalculator.Text = (miles / gallons).ToString();
        
           

        }

        private void txtMile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMile.Text))
            {
                e.Cancel = true;
                txtMile.Focus();
                errorProvider1.SetError(txtMile, "Vui lòng không bỏ trống");
                MessageBox.Show("Vui lòng không bỏ trống", "Lỗi");

            }
            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMile, null);
            }

        }

   

        private void txtMile_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMile.Text,"[^0-9]+"))
            {
                errorProvider1.SetError(txtMile, "Nhập số và không được nhỏ hơn 0");
                MessageBox.Show("Nhập số và không được nhỏ hơn 0", "Lỗi");
                txtMile.Clear();
                txtMile.Focus();
            }
        }

        private void txtGallon_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtGallon.Text,"[^0-9]+"))
            {
                errorProvider1.SetError(txtGallon, "Nhập số và không được nhỏ hơn 0");
                MessageBox.Show("Nhập số và không được nhỏ hơn 0","Lỗi");
                txtGallon.Clear();
                txtGallon.Focus();
            }
            else if (txtGallon.Text == "0")
            {
                errorProvider1.SetError(txtGallon, "Lỗi chia cho 0");
                MessageBox.Show("Lỗi chia cho 0", "Lỗi");
                txtGallon.Clear();
                txtGallon.Focus();
            }
        }

        private void txtGallon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGallon.Text))
            {
                e.Cancel = true;
                txtMile.Focus();
                errorProvider1.SetError(txtGallon, "Vui lòng không bỏ trống");
                MessageBox.Show("Vui lòng không bỏ trống", "Lỗi");

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtGallon, null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingFlag = true;
            e.Cancel = false;
        }
    }


}
