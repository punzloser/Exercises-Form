using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string input = "";

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)

        {

            //MessageBox.Show("code:" + e.KeyCode.ToString() + "\ndata:" + e.KeyData.ToString() + "\nvalue:" +

            // e.KeyValue.ToString());


            input = e.KeyData.ToString();
            SuKienKeyDown();

        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)

        {

            input = e.KeyData.ToString();
            SuKienKeyUp();

        }

        private void SuKienKeyDown()

        {

            foreach (Control ctrlChild in this.Controls)

            {

                if (ctrlChild.GetType() == typeof(Label))

                {
                    if (ctrlChild.Text.ToUpper() == input.ToUpper() || "NumPad" + ctrlChild.Text == input || "D" + ctrlChild.Text == input)

                    {

                        ctrlChild.BackColor = Color.OrangeRed;

                    }

                }

            }

        }

        private void SuKienKeyUp()

        {

            foreach (Control ctrlChild in this.Controls)

            {

                if (ctrlChild.GetType() == typeof(Label))

                {

                    if (ctrlChild.Text.ToUpper() == input.ToUpper() || "NumPad" + ctrlChild.Text == input || "D" + ctrlChild.Text == input)

                    {

                        ctrlChild.BackColor = Color.Transparent;

                    }

                }

            }

        }
    }
}