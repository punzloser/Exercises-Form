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
    public partial class frmLop : Form
    {
        string opt = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            lockDisplay();
            loadMaKhoa();
            loadForm();

            displayGridview();
        }

        private void lockDisplay()
        {
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            txtSiSo.Enabled = false;
            cbbMaKhoa.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void showDisplay()
        {
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            txtSiSo.Enabled = true;
            cbbMaKhoa.Enabled = true;

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

        private void loadMaKhoa()
        {
            cbbMaKhoa.ValueMember = "TenKhoa";
            cbbMaKhoa.DisplayMember = "MaKhoa";
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbMaKhoa.DataSource = b;
        }

        private void loadForm()
        {
            DataSet1.LopDataTable b = new DataSet1.LopDataTable();
            DataSet1TableAdapters.LopTableAdapter a = new DataSet1TableAdapters.LopTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;

            if (dataGridView1.Rows.Count > 0)
            {
                txtMaLop.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenLop.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSiSo.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaKhoa.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtMaLop.Focus();

            lockDisplay();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaLop.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenLop.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSiSo.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaKhoa.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            cbbMaKhoa.Text = "";
            txtMaLop.Focus();
            opt = "1";

            showDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.LopDataTable b = new DataSet1.LopDataTable();
            DataSet1TableAdapters.LopTableAdapter a = new DataSet1TableAdapters.LopTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemLop(b, txtMaLop.Text, txtTenLop.Text, txtSiSo.Text, cbbMaKhoa.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaLop(b, txtMaLop.Text, txtTenLop.Text, txtSiSo.Text, cbbMaKhoa.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.LopDataTable b = new DataSet1.LopDataTable();
            DataSet1TableAdapters.LopTableAdapter a = new DataSet1TableAdapters.LopTableAdapter();
            b.Reset();
            a.XoaLop(b, txtMaLop.Text);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            opt = "";
            loadForm();
        }

        private void cbbMaKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaKhoa.SelectedIndex >= 0)
            {
                lbMaKhoa.Text = cbbMaKhoa.SelectedValue.ToString();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
