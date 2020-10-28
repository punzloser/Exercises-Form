using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNguyenHoangThanh
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
            loadDT();
            loadForm();
        }

        private void loadForm()
        {
            if (cbbChonDeTai.SelectedIndex >= 0)
            {
                DataSet1.DeTaiDataTable b = new DataSet1.DeTaiDataTable();
                DataSet1TableAdapters.DeTaiTableAdapter a = new DataSet1TableAdapters.DeTaiTableAdapter();
                b.Reset();
                a.ChonDTTheoLoaiDT(b, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.Rows.Count > 0)
                {
                    txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtTenGVHD.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
            opt = "";
            txtTenDeTai.Focus();
        }

        private void loadDT()
        {
            cbbChonDeTai.ValueMember = "MaLoaiDT";
            cbbChonDeTai.DisplayMember = "TenLoaiDT";
            DataSet1.LoaiDeTaiDataTable b = new DataSet1.LoaiDeTaiDataTable();
            DataSet1TableAdapters.LoaiDeTaiTableAdapter a = new DataSet1TableAdapters.LoaiDeTaiTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonDeTai.DataSource = b;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtTenGVHD.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void cbbChonDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenDeTai.Clear();
            txtDiem.Clear();
            txtTenGVHD.Clear();
            txtTenDeTai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataSet1.DeTaiDataTable b = new DataSet1.DeTaiDataTable();
            DataSet1TableAdapters.DeTaiTableAdapter a = new DataSet1TableAdapters.DeTaiTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemDT(b, txtTenDeTai.Text, double.Parse(txtDiem.Text), txtTenGVHD.Text, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                long MaDT = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.SuaDT(b, MaDT,txtTenDeTai.Text, double.Parse(txtDiem.Text), txtTenGVHD.Text, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            opt = "";
            loadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataSet1.DeTaiDataTable b = new DataSet1.DeTaiDataTable();
            DataSet1TableAdapters.DeTaiTableAdapter a = new DataSet1TableAdapters.DeTaiTableAdapter();
            b.Reset();
            long MaDT = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            a.XoaDT(b, MaDT);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
