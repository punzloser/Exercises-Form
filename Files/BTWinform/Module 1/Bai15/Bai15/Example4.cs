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
    public partial class Example4 : Form
    {
        MessageBoxButtons buttons;
        MessageBoxOptions layout;
        MessageBoxIcon icon;
        public Example4()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string message = txtContent.Text;
            string caption = txtCaption.Text;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            
        }

        private void radOK_CheckedChanged(object sender, EventArgs e)
        {
            buttons = MessageBoxButtons.OK;
        }

        private void radO_Cancle_CheckedChanged(object sender, EventArgs e)
        {
            buttons = MessageBoxButtons.OKCancel;
        }

        private void radR_Cancel_CheckedChanged(object sender, EventArgs e)
        {
            buttons = MessageBoxButtons.RetryCancel;
        }

        private void radY_N_CheckedChanged(object sender, EventArgs e)
        {
            buttons = MessageBoxButtons.YesNo;
        }

        private void radY_N_C_CheckedChanged(object sender, EventArgs e)
        {
            buttons = MessageBoxButtons.YesNoCancel;
        }

        private void radError_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Error;
        }

        private void radInfo_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Information;
        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.None;
        }

        private void radQuestion_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Question;
        }

        private void radWarning_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Warning;
        }

        private void radLeft_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
