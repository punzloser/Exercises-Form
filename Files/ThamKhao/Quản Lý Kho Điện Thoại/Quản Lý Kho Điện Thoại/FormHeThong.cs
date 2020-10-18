using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Kho_Điện_Thoại
{
    public partial class FormHeThong : Form
    {
        public FormHeThong()
        {
            InitializeComponent();
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhoDienThoai F = new FormQuanLyKhoDienThoai();
            F.Show();
        }
    }
}
