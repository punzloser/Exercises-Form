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
            frmKhoa a = new frmKhoa();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongHoc a = new frmPhongHoc();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien a = new frmGiaoVien();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop a = new frmLop();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc a = new frmMonHoc();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void xếpThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChonThoiKhoaBieu a = new frmChonThoiKhoaBieu();
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
