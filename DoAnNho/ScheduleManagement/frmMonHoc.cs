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
    public partial class frmMonHoc : Form
    {
        string opt = "";
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            lockDisplay();
            loadForm();

            displayGridview();
        }

        private void lockDisplay()
        {
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtTongTiet.Enabled = false;
            txtSoTin.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void showDisplay()
        {
            txtMaMon.Enabled = true;
            txtTenMon.Enabled = true;
            txtTongTiet.Enabled = true;
            txtSoTin.Enabled = true;

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
            DataSet1.MonHocDataTable b = new DataSet1.MonHocDataTable();
            DataSet1TableAdapters.MonHocTableAdapter a = new DataSet1TableAdapters.MonHocTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;

            if (dataGridView1.Rows.Count > 0)
            {
                txtMaMon.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenMon.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTongTiet.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoTin.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtMaMon.Focus();

            lockDisplay();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtMaMon.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenMon.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTongTiet.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoTin.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            showDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtTongTiet.Clear();
            txtSoTin.Clear();
            txtMaMon.Focus();
            opt = "1";

            showDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.MonHocDataTable b = new DataSet1.MonHocDataTable();
            DataSet1TableAdapters.MonHocTableAdapter a = new DataSet1TableAdapters.MonHocTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemMon(b, txtMaMon.Text, txtTenMon.Text, txtTongTiet.Text, txtSoTin.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                a.SuaMon(b, txtMaMon.Text, txtTenMon.Text, txtTongTiet.Text, txtSoTin.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet1.MonHocDataTable b = new DataSet1.MonHocDataTable();
            DataSet1TableAdapters.MonHocTableAdapter a = new DataSet1TableAdapters.MonHocTableAdapter();
            b.Reset();
            a.XoaMon(b, txtMaMon.Text);
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
