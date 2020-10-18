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
    public partial class frmKhoa : Form
    {
        string opt = "";
        public frmKhoa()
        {
            InitializeComponent();     
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            lockDisplay();
            loadForm();

            displayGridview();
        }

        private void lockDisplay()
        {
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void showDisplay()
        {
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        public void displayGridview()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void loadForm()
        {
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;

            if (dataGridView1.Rows.Count > 0)
            {
                txtMaKhoa.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenKhoa.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDienThoai.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtEmail.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtMaKhoa.Focus();
            lockDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtMaKhoa.Focus();
            opt = "1";

            showDisplay();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            
            if (opt == "1")
            {
                a.ThemKhoa(b, txtMaKhoa.Text, txtTenKhoa.Text, txtDienThoai.Text, txtEmail.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaKhoa(b, txtMaKhoa.Text, txtTenKhoa.Text, txtDienThoai.Text, txtEmail.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");     
            }
            loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaKhoa.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenKhoa.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDienThoai.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtEmail.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            a.XoaKhoa(b, txtMaKhoa.Text);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            opt = "";
            loadForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
