using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Enabled = false;

            IsMdiContainer = true;
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Khoa a = new frm_Khoa();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhongHoc a = new frm_PhongHoc();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GiaoVien a = new frm_GiaoVien();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Lop a = new frm_Lop();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MonHoc a = new frm_MonHoc();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void xếpThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChonThoiKhoaBieu a = new frm_ChonThoiKhoaBieu();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void xemThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemThoiKhoaBieu a = new frmXemThoiKhoaBieu();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Hoàng Thanh","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
