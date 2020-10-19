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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            loadForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loadForm();
            }
        }

        private void loadForm()
        {
            DataSet1.DangNhapDataTable b = new DataSet1.DangNhapDataTable();
            DataSet1TableAdapters.DangNhapTableAdapter a = new DataSet1TableAdapters.DangNhapTableAdapter();
            b.Reset();
            int kq = a.DN(b, txtUsername.Text, txtPassword.Text);

            if (kq == 1)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                frmMain fr = new frmMain();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Lỗi");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lbUsername.Enabled = false;
            lbPassword.Enabled = false;
        }
    }
}
