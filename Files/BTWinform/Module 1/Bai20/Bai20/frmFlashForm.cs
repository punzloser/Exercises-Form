using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20
{
    public partial class frmFlashForm : Form
    {
        public frmFlashForm()
        {
            InitializeComponent();
        }

        private void frmFlashForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            this.DialogResult = DialogResult.OK;


        }


    }
}
