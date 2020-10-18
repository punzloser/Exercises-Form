using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtMainstring.Text.Contains(txtsearch.Text))
                MessageBox.Show("Tìm thấy", "Thông báo!");
            else
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            
                if(txtMainstring.Text.Contains(txtsearch.Text))
                {

                  txtMainstring.Text=  txtMainstring.Text.Replace(txtsearch.Text, txtreplace.Text);
                         MessageBox.Show("Đã sửa","Thông báo!");              
                }
                else
                    MessageBox.Show("Không tìm thấy!", "Thông báo!");        
        
               
            
        }

        
    }
}
