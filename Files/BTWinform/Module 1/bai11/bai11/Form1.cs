using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                //Image img = Image.FromFile(openFileDialog1.FileName);
                FileInfo img = new FileInfo(openFileDialog1.FileName);
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                lblSize.Text = (img.Length).ToString() + "bytes";
                DateTime modify_at = img.LastWriteTime;
                DateTime access_at = img.LastAccessTime;
                lblModified.Text = modify_at.ToString();
                lblAccessed.Text = access_at.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
