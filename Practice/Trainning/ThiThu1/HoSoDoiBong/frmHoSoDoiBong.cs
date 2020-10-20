using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoSoDoiBong
{
    public partial class frmHoSoDoiBong : Form
    {
        public frmHoSoDoiBong()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoSoDoiBong_Load(object sender, EventArgs e)
        {
            LoadBangMaDoi();
            LoadData();
        }

        private void LoadBangMaDoi()
        {
            cbbMaDoi.ValueMember = "MaDoi";
            cbbMaDoi.DisplayMember = "TenDoi";
            DataSet1.DoiBongDataTable b = new DataSet1.DoiBongDataTable();
            DataSet1TableAdapters.DoiBongTableAdapter a = new DataSet1TableAdapters.DoiBongTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbMaDoi.DataSource = b;
        }

        private void LoadData()
        {
            if (cbbMaDoi.SelectedIndex >= 0)
            {
                DataSet1.CauThuDataTable b = new DataSet1.CauThuDataTable();
                DataSet1TableAdapters.CauThuTableAdapter a = new DataSet1TableAdapters.CauThuTableAdapter();
                b.Reset();
                a.ChonCauThuTheoDoi(b, cbbMaDoi.SelectedValue.ToString()); 
                //
                // Error
                //

                dataGridView1.DataSource = b;

                if (dataGridView1.RowCount > 0)
                {
                    txtMaCauThu.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtTenCauThu.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtNgaySinh.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtLoaiCauThu.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtGhiChu.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtSanNha.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
        }
        private void cbbMaDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCauThu.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            txtTenCauThu.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtNgaySinh.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txtLoaiCauThu.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            txtGhiChu.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            txtSanNha.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
        }
    }
}
