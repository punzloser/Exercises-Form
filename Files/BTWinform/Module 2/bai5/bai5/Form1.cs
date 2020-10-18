using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        decimal tienmay = 100;
        decimal tiennguoi = 100;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            lblso1.Text = "7";
            lblso2.Text = "7";
            lblso3.Text = "7";
           txtMay.Text = "100";
            txtNguoichoi.Text = "100";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal tienthuong;
            int so1;
            int so3;
            int so2;
            timer1.Interval += 5;
            Random ran = new Random();
            so1 = ran.Next(0, 8);
            so2 = ran.Next(0, 9);
            so3 = ran.Next(0, 10);

            lblso1.Text = so1.ToString();
            lblso2.Text = so2.ToString();
            lblso3.Text = so3.ToString();

            if(timer1.Interval >200)
            {
                timer1.Stop();
                if(so1 ==7)
                {
                    tienthuong = 100 + (tienmay * 50) / 100;
                    tiennguoi = tiennguoi + tienthuong;
                    tienmay = tienmay - (tienmay * 50) / 100;
                    MessageBox.Show("Bạn được thưởng " + Math.Round(tienthuong,2) + " đồng, Lucky Seven!");

                }
                if (so2 == 7)
                {
                    tienthuong = 30 + (tienmay * 50) / 100;
                    tiennguoi = tiennguoi + tienthuong;
                    tienmay = tienmay - (tienmay * 50) / 100;
                    MessageBox.Show("Bạn được thưởng " + Math.Round(tienthuong,2) + " đồng, Lucky Seven!");

                }
                if (so3 == 7)
                {
                    tienthuong = 10;
                    tiennguoi = tiennguoi + tienthuong;
                    tienmay = tienmay - (tienmay * 50) / 100;
                    MessageBox.Show("Bạn được thưởng " + Math.Round(tienthuong,2) + " đồng, Lucky Seven!");

                }

                txtNguoichoi.Text = Math.Round(tiennguoi,2).ToString();
                txtMay.Text = Math.Round(tienmay,2).ToString();

            }
        }

        private void btnQuayso_Click(object sender, EventArgs e)
        {
            if(tiennguoi >=30)
            {
                timer1.Enabled = true;
                timer1.Interval = 2;
                tienmay = tienmay + 30;
                tiennguoi = tiennguoi - 30;
            }
            else
            {
                MessageBox.Show("Không đủ tiền! Bạn không thể chơi tiếp!");
                timer1.Stop();
                btnQuayso.Enabled = false;
            }
        }

        private void btnGamemoi_Click(object sender, EventArgs e)
        {
            lblso1.Text = "7";
            lblso2.Text = "7";
            lblso3.Text = "7";
            txtMay.Text = "100";
            txtNguoichoi.Text = "100";
            btnQuayso.Enabled = true;
            tiennguoi = 100;
            tienmay = 100;

        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    
    }
}
