using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {

        DateTime bd1, bd2, kt1, kt2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnbd2.Enabled = true;
            btnbd1.Enabled = true;
           
            btnkt1.Enabled = false;
            btnkt2.Enabled = false;
            txtbd1.Text = "";
            txtbd2.Text = "";
            txtkt1.Text = "";
            txtkt2.Text = "";
        }

        private void btnbd1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnbd1.Enabled = false;
            btnkt1.Enabled = true;
            bd1 = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtbd1.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void btnbd2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            btnbd2.Enabled = false;
            btnkt2.Enabled = true;
            bd2 = DateTime.Now;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtbd2.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void btnkt1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnkt1.Enabled = false;
            btnbd1.Enabled = true;
            txtkt1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            kt1 = DateTime.Now;
            var gio1 = (kt1 - bd1).TotalMinutes;
            double tien1 = Math.Ceiling(gio1) * 3000/60;
            MessageBox.Show("Số giờ thuê là: " + Math.Floor(gio1/60) +":"+Math.Ceiling(gio1%60)+ "\nSố tiền phải trả là: " + tien1,"Thông báo máy 1");

            txtbd1.Text = "";
            txtkt1.Text = "";

        }

        private void btnkt2_Click(object sender, EventArgs e)
        {

            timer2.Enabled = false;
            btnkt2.Enabled = false;
            btnbd2.Enabled = true;
            txtkt2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            kt2 = DateTime.Now;
            var gio2 = (kt2 - bd2).TotalMinutes;
            double tien2 = Math.Ceiling(gio2) * 3000 / 60;
            MessageBox.Show("Số giờ thuê là: " + Math.Floor(gio2 / 60) + ":" + Math.Ceiling(gio2 % 60) + "\nSố tiền phải trả là: " + tien2, "Thông báo máy 2");
            txtbd2.Text = "";
            txtkt2.Text = "";

        }
    }
}
