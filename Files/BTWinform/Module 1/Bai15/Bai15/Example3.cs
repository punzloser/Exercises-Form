using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15
{
    public partial class Example3 : Form
    {
        float per = 0;
        public Example3()
        {
            InitializeComponent();
        }

        private void Example3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Enable the timer.
            timer1.Start();//Strart it
            timer1.Interval = 1000; // The time per tick.
            progressBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
                per = (progressBar1.Value % progressBar1.Maximum);
                lblPercent.Text = per.ToString() + "%";
            }
            else
            {
                timer1.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 - trackBar1.Value;
        }
    }
}
