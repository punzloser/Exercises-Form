using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số dự đoán!");
                txtSo.Focus();
            }
            else
            {
                int n;
                if(!int.TryParse(txtSo.Text, out n))
                {
                    MessageBox.Show("Vui lòng nhập số từ 0 -> 9");
                }
                Random rd = new Random();
                int random = rd.Next(0, 10);
                lblKetQua.Text = random.ToString();
                if(n == random)
                {
                    MessageBox.Show("Chúc mừng bạn đã đoán trúng!");

                }
                else
                {
                    MessageBox.Show("Chúc bạn may mắn lần sau!");
                }
            }
             
            
        }
    }
}
