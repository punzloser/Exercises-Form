using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appdaotao
{
    public partial class Form1 : Form
    {
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBangKhoa();
            LoadDataGridView();
        }

        //1.Load du lieu combox
        private void LoadBangKhoa()
        {
            cbbChonKhoa.ValueMember = "MaKhoa";
            cbbChonKhoa.DisplayMember = "TenKhoa";
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonKhoa.DataSource = b;
        }

        //2. Load du lieu vào dataGrid View
        private void LoadDataGridView()
        {
            if (cbbChonKhoa.SelectedIndex >= 0)
            {
                DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
                DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
                b.Reset();
                a.ChonGVTheoKhoa(b, short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.RowCount > 0)
                {
                    txtTenGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtLuong.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtSoDT.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        //3. Viết sự CellClick hiện thị dữ liệu lên các ô Text box.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtLuong.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txtSoDT.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
        }
        //4. Viết xử lý thêm mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenGV.Clear();
            txtLuong.Clear();
            txtSoDT.Clear();
            txtTenGV.Focus();
        }

        //5. Viết xử lý Lưu cho phần thêm mới
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();
            if (opt == "1")
            {
                a.GiaoVienInsert(b, txtTenGV.Text, txtSoDT.Text, double.Parse(txtLuong.Text), short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
            }
            else
            {
                if (dataGridView1.RowCount > 0) 
                {
                    long MaGV = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    a.GiaoVienUpdate(b, MaGV, txtTenGV.Text, txtSoDT.Text, double.Parse(txtLuong.Text), short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                    MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
                }
            }
            LoadDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            opt = "";
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
                DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
                b.Reset();
                long MaGV = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.GiaoVienDelete(b, MaGV);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
            }
            LoadDataGridView();
        }
    }
}
