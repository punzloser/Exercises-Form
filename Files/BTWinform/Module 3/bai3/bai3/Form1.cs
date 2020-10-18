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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"D:\BaiTapWinform\module3\bai3\" + txtName.Text + ".txt";
            System.IO.File file = new System.IO.File(path);
            try
            {
                System.IO.File.WriteAllText(, rtbContent.Text);
            }
            catch (Exception a)
            {
                Console.WriteLine("{0} Exception caught.", a);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
