using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppbanhangThanh
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
            loadSP();
            loadForm();
        }

        private void loadForm()
        {
            DataSet1.SanPhamDataTable b = new DataSet1.SanPhamDataTable();
            DataSet1TableAdapters.SanPhamTableAdapter a = new DataSet1TableAdapters.SanPhamTableAdapter();
            b.Reset();
            if (cbbLoaiSP.SelectedIndex >= 0)
            {
                
                a.ChonSPTheoLoai(b, short.Parse(cbbLoaiSP.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.Rows.Count > 0)
                {
                    txtTenSP.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtDonGia.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtSoTon.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
            opt = "";
            txtTenSP.Focus();
        }

        private void loadSP()
        {
            cbbLoaiSP.ValueMember = "MaLoaiSP";
            cbbLoaiSP.DisplayMember = "TenLoaiSP";
            DataSet1.LoaiSPDataTable b = new DataSet1.LoaiSPDataTable();
            DataSet1TableAdapters.LoaiSPTableAdapter a = new DataSet1TableAdapters.LoaiSPTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbLoaiSP.DataSource = b;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTenSP.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDonGia.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoTon.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoTon.Clear();
            txtTenSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataSet1.SanPhamDataTable b = new DataSet1.SanPhamDataTable();
            DataSet1TableAdapters.SanPhamTableAdapter a = new DataSet1TableAdapters.SanPhamTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemSP(b, txtTenSP.Text, double.Parse(txtDonGia.Text), int.Parse(txtSoTon.Text), short.Parse(cbbLoaiSP.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                long MaSP = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.SuaSP(b, MaSP, txtTenSP.Text, double.Parse(txtDonGia.Text), int.Parse(txtSoTon.Text), short.Parse(cbbLoaiSP.SelectedValue.ToString()));
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
            DataSet1.SanPhamDataTable b = new DataSet1.SanPhamDataTable();
            DataSet1TableAdapters.SanPhamTableAdapter a = new DataSet1TableAdapters.SanPhamTableAdapter();
            b.Reset();
            long MaSP = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            a.XoaSP(b, MaSP);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
