using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblThongBao.Text = txtName.Text + ", Turn Off the light";
        }

        private void picLightOff_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picLightOff, "Click to turn On");
        }

        private void picLightOn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picLightOn, "Click to turn Off");
        }

        private void picLightOn_Click(object sender, EventArgs e)
        {
            picLightOn.Visible = false;
            picLightOff.Visible = true;
            lblThongBao.Text = txtName.Text + ", Turn On the light";
        }

        private void picLightOff_Click(object sender, EventArgs e)
        {
            picLightOn.Visible = true;
            picLightOff.Visible = false;
            lblThongBao.Text = txtName.Text + ", Turn Off the light";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
