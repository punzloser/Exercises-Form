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
        

       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                

                float miles, gallons;
                miles = float.Parse(txtMile.Text);
                gallons = float.Parse(txtGallon.Text);

               

                if (miles < 0)
                    throw new IndexOutOfRangeException("Bạn đã nhập số âm! vui lòng nhập số lớn hơn 0!");
             
                if (gallons < 0)
                    throw new IndexOutOfRangeException("Bạn đã nhập số âm! vui lòng nhập số lớn hơn 0!");
                if (gallons == 0)
                    throw new IndexOutOfRangeException("Lỗi chia cho 0!");

                txtCalculator.Text = (miles / gallons).ToString();
            }
            catch(IndexOutOfRangeException f)
            {
                txtCalculator.Clear();
                MessageBox.Show("Exception: " +f.Message);
            }

            catch (FormatException g)
            {
                MessageBox.Show("Exception: " + g.Message);
            }

        }
        }


}
