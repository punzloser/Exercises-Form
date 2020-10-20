using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDetai
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
            loadChonDeTai();
            loadForm();
        }

        private void loadChonDeTai()
        {
            cbbChonLoaiDeTai.ValueMember = "MaLoaiDT";
            cbbChonLoaiDeTai.DisplayMember = "TenLoaiDeTai";
            DataSet1.LoaiDTDataTable b = new DataSet1.LoaiDTDataTable();
            DataSet1TableAdapters.LoaiDTTableAdapter a = new DataSet1TableAdapters.LoaiDTTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonLoaiDeTai.DataSource = b;
        }

        private void loadForm()
        {
            if (cbbChonLoaiDeTai.SelectedIndex >= 0)
            {
                DataSet1.detaiDataTable b = new DataSet1.detaiDataTable();
                DataSet1TableAdapters.detaiTableAdapter a = new DataSet1TableAdapters.detaiTableAdapter();
                b.Reset();
                a.spud_ChonDeTaiTheoLoaiDeTai(b, int.Parse(cbbChonLoaiDeTai.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.Rows.Count > 0)
                {
                    txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtGVHD.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
            txtTenDeTai.Focus();
            opt = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtGVHD.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void cbbChonLoaiDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenDeTai.Clear();
            txtDiem.Clear();
            txtGVHD.Clear();
            txtTenDeTai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataSet1.detaiDataTable b = new DataSet1.detaiDataTable();
            DataSet1TableAdapters.detaiTableAdapter a = new DataSet1TableAdapters.detaiTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.spud_ThemDeTai(b, txtTenDeTai.Text, double.Parse(txtDiem.Text), txtGVHD.Text, int.Parse(cbbChonLoaiDeTai.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                long MaDT = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.spud_SuaDeTai(b, MaDT,txtTenDeTai.Text, double.Parse(txtDiem.Text), txtGVHD.Text, int.Parse(cbbChonLoaiDeTai.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataSet1.detaiDataTable b = new DataSet1.detaiDataTable();
            DataSet1TableAdapters.detaiTableAdapter a = new DataSet1TableAdapters.detaiTableAdapter();
            b.Reset();
            long MaDT = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            a.spud_XoaDeTai(b, MaDT);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            loadForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            opt = "";
            loadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
