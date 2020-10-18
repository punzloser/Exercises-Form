using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form1 : Form
    {
        DateTime bd1, bd2, kt1, kt2;
        public Form1()
        {
            InitializeComponent();
        }

        private void pbKetthuc1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pbKetthuc1.Visible = false;
            pbBatdau1.Visible = true;
            txtKetthuc1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            kt1 = DateTime.Now;
            var gio1 = (kt1 - bd1).TotalMinutes;
            double tien1 = Math.Ceiling(gio1) * 3000 / 60;
            MessageBox.Show("Số giờ thuê là: " + Math.Floor(gio1 / 60) + ":" + Math.Ceiling(gio1 % 60) + "\nSố tiền phải trả là: " + tien1, "Thông báo máy 1");

            txtKetthuc1.Text = "";
            txtBatdau1.Text = "";
        }

        private void pbKetthuc2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            pbKetthuc2.Visible = false;
            pbBatdau2.Visible = true;
            txtKetthuc2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            kt2 = DateTime.Now;
            var gio2 = (kt2 - bd2).TotalMinutes;
            double tien2 = Math.Ceiling(gio2) * 3000 / 60;
            MessageBox.Show("Số giờ thuê là: " + Math.Floor(gio2 / 60) + ":" + Math.Ceiling(gio2 % 60) + "\nSố tiền phải trả là: " + tien2, "Thông báo máy 1");

            txtKetthuc2.Text = "";
            txtBatdau2.Text = "";
        }

        private void pbBatdau2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            pbBatdau2.Visible = false;
            pbKetthuc2.Visible = true;
            bd2 = DateTime.Now;
            txtBatdau2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            txtKetthuc2.Text = "";
            txtKetthuc1.Text = "";
            txtBatdau1.Text = "";
            txtBatdau2.Text = "";
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {

            txtKetthuc1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtKetthuc2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pbBatdau1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pbBatdau1.Visible = false;
            pbKetthuc1.Visible = true;
            bd1 = DateTime.Now;
            txtBatdau1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
