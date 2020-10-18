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
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            lblSample.ForeColor = Color.FromName(domainUpDown1.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float size = float.Parse(numericUpDown1.Value.ToString());
            lblSample.Font = new Font(lblSample.Font.Name, size,
                lblSample.Font.Style);
        }
    }
}
