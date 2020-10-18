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
    public partial class frmChonThoiKhoaBieu : Form
    {
        string opt = "";
        public frmChonThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void frmChonThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            lockDisplay();

            loadChonMaGV();

            loadMaGV();
            loadMaLop();
            loadMaMon();
            loadMaPhong();
            loadForm();

            displayGridview();
        }

        private void showDisplay()
        {
            dtpNgay.Enabled = true;
            cbbMaGV.Enabled = true;
            cbbMaLop.Enabled = true;
            cbbMaMon.Enabled = true;
            cbbMaPhong.Enabled = true;
            cbbBuoi.Enabled = true;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void lockDisplay()
        {
            dtpNgay.Enabled = false;
            cbbMaGV.Enabled = false;
            cbbMaLop.Enabled = false;
            cbbMaMon.Enabled = false;
            cbbMaPhong.Enabled = false;
            cbbBuoi.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
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
            if (cbbChonGV.SelectedIndex >= 0)
            {
                DataSet1.TKBDataTable b = new DataSet1.TKBDataTable();
                DataSet1TableAdapters.TKBTableAdapter a = new DataSet1TableAdapters.TKBTableAdapter();
                b.Reset();
                a.ChonTKBTheoMaGV(b, cbbChonGV.SelectedValue.ToString());
                dataGridView1.DataSource = b;

                if (dataGridView1.Rows.Count > 0)
                {
                    dtpNgay.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                    cbbMaGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    cbbMaLop.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    cbbMaMon.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                    cbbMaPhong.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                    cbbBuoi.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                }
                opt = "";
                lockDisplay();
            }
        }

        private void loadMaPhong()
        {
            cbbMaPhong.ValueMember = "TenPhong";
            cbbMaPhong.DisplayMember = "MaPhong";
            DataSet1.PhongHocDataTable b = new DataSet1.PhongHocDataTable();
            DataSet1TableAdapters.PhongHocTableAdapter a = new DataSet1TableAdapters.PhongHocTableAdapter(); 
            b.Reset();
            a.Fill(b);
            cbbMaPhong.DataSource = b;
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

        private void loadMaLop()
        {
            cbbMaLop.ValueMember = "TenLop";
            cbbMaLop.DisplayMember = "MaLop";
            DataSet1.LopDataTable b = new DataSet1.LopDataTable();
            DataSet1TableAdapters.LopTableAdapter a = new DataSet1TableAdapters.LopTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbMaLop.DataSource = b;
        }

        private void loadMaGV()
        {
            cbbMaGV.ValueMember = "TenGV";
            cbbMaGV.DisplayMember = "MaGV";
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbMaGV.DataSource = b;
        }

        private void loadChonMaGV()
        {
            cbbChonGV.ValueMember = "MaGV";
            cbbChonGV.DisplayMember = "TenGV";
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonGV.DataSource = b;
        }

        private void cbbChonGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void cbbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaGV.SelectedIndex >=0)
            {
                lbMaGV.Text = cbbMaGV.Text + " - " + cbbMaGV.SelectedValue.ToString();
            }
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedIndex >= 0)
            {
                lbMaLop.Text = cbbMaLop.Text + " - " + cbbMaLop.SelectedValue.ToString();
            }
        }

        private void cbbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaMon.SelectedIndex >= 0)
            {
                lbMaMon.Text = cbbMaMon.Text + " - " + cbbMaMon.SelectedValue.ToString();
            }
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaPhong.SelectedIndex >= 0)
            {
                lbMaPhong.Text = cbbMaPhong.Text + " - " + cbbMaPhong.SelectedValue.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showDisplay();

            dtpNgay.Text = "";
            cbbMaGV.Text = "";
            cbbMaLop.Text = "";
            cbbMaMon.Text = "";
            cbbMaPhong.Text = "";
            cbbBuoi.Text = "";

            opt = "1";
            dtpNgay.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.TKBDataTable b = new DataSet1.TKBDataTable();
            DataSet1TableAdapters.TKBTableAdapter a = new DataSet1TableAdapters.TKBTableAdapter();
            b.Reset();
            if (opt == "1")
            {
                a.ThemTKB(b, DateTime.Parse(dtpNgay.Text), cbbMaGV.Text, cbbMaLop.Text, cbbMaMon.Text, cbbMaPhong.Text, cbbBuoi.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaTKB(b, DateTime.Parse(dtpNgay.Text), cbbMaGV.Text, cbbMaLop.Text, cbbMaMon.Text, cbbMaPhong.Text, cbbBuoi.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dtpNgay.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaLop.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaMon.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbMaPhong.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                cbbBuoi.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            opt = "";
            loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.TKBDataTable b = new DataSet1.TKBDataTable();
            DataSet1TableAdapters.TKBTableAdapter a = new DataSet1TableAdapters.TKBTableAdapter();
            b.Reset();
            a.XoaTKB(b, cbbMaGV.Text, cbbMaLop.Text, cbbMaMon.Text, cbbMaPhong.Text);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
