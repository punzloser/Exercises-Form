using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManagement
{
    public partial class frm_PhongHoc : ScheduleManagement.frmChung
    {
        string opt = "";
        public frm_PhongHoc()
        {
            InitializeComponent();
        }

        private void frm_PhongHoc_Load(object sender, EventArgs e)
        {
            lockDisplay();
            loadFrom();

            displayGridview();
        }

        private void lockDisplay()
        {
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtChucNang.Enabled = false;
            txtSucChua.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void showDisplay()
        {
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtChucNang.Enabled = true;
            txtSucChua.Enabled = true;

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

        private void loadFrom()
        {
            DataSet1.PhongHocDataTable b = new DataSet1.PhongHocDataTable();
            DataSet1TableAdapters.PhongHocTableAdapter a = new DataSet1TableAdapters.PhongHocTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaPhong.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenPhong.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtChucNang.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSucChua.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtMaPhong.Focus();
            lockDisplay();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaPhong.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenPhong.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtChucNang.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSucChua.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtChucNang.Clear();
            txtMaPhong.Clear();
            txtSucChua.Clear();
            txtTenPhong.Clear();
            txtMaPhong.Focus();
            opt = "1";

            showDisplay();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.PhongHocDataTable b = new DataSet1.PhongHocDataTable();
            DataSet1TableAdapters.PhongHocTableAdapter a = new DataSet1TableAdapters.PhongHocTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemPhong(b, txtMaPhong.Text, txtTenPhong.Text, txtChucNang.Text, txtSucChua.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaPhong(b, txtMaPhong.Text, txtTenPhong.Text, txtChucNang.Text, txtSucChua.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadFrom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.PhongHocDataTable b = new DataSet1.PhongHocDataTable();
            DataSet1TableAdapters.PhongHocTableAdapter a = new DataSet1TableAdapters.PhongHocTableAdapter();
            b.Reset();
            a.XoaPhong(b, txtMaPhong.Text);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadFrom();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            opt = "";
            loadFrom();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
