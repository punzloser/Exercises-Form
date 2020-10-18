using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManagement
{
    public partial class frmGiaoVien : Form
    {
        string opt = "";
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            lockDisplay();
            loadMaMon();
            loadForm();

            displayGridview();
        }

        private void showDisplay()
        {
            txtMaGV.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            cbbMaMon.Enabled = true;
            txtChuyenNganh.Enabled = true;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void lockDisplay()
        {
            txtMaGV.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbbGioiTinh.Enabled = false;
            cbbMaMon.Enabled = false;
            txtChuyenNganh.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        public void displayGridview()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void loadMaMon()
        {
            cbbMaMon.ValueMember = "TenMon";
            cbbMaMon.DisplayMember = "MaMon";
            DataSet1.MonHocDataTable b = new DataSet1.MonHocDataTable();
            DataSet1TableAdapters.MonHocTableAdapter a = new DataSet1TableAdapters.MonHocTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbMaMon.DataSource = b;
        }

        private void loadForm()
        {
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaGV.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTen.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                dtpNgaySinh.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbGioiTinh.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaMon.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                txtChuyenNganh.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtMaGV.Focus();
            lockDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            cbbMaMon.Text = "";
            txtChuyenNganh.Clear();
            txtMaGV.Focus();
            opt = "1";
            showDisplay();

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaGV.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTen.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                dtpNgaySinh.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbGioiTinh.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaMon.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                txtChuyenNganh.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemGiaoVien(b, txtMaGV.Text, txtTen.Text, txtDiaChi.Text, DateTime.Parse(dtpNgaySinh.Text), cbbGioiTinh.Text, cbbMaMon.Text, txtChuyenNganh.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaGiaoVien(b, txtMaGV.Text, txtTen.Text, txtDiaChi.Text, DateTime.Parse(dtpNgaySinh.Text), cbbGioiTinh.Text, cbbMaMon.Text, txtChuyenNganh.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();
            a.XoaGiaoVien(b, txtMaGV.Text);
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

        private void cbbMaMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaMon.SelectedIndex >= 0)
            {
                lbMaMon.Text = cbbMaMon.SelectedValue.ToString();
            }
        }
    }
}
