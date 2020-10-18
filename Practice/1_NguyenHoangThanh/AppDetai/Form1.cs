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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDeTai();
            LoadData();
        }

        //2
        private void LoadData()
        {
            if (cbbChonDeTai.SelectedIndex >= 0)
            {
                DataSet1.detaiDataTable b = new DataSet1.detaiDataTable();
                DataSet1TableAdapters.detaiTableAdapter a = new DataSet1TableAdapters.detaiTableAdapter();
                b.Reset();
                a.ChonDeTaiTheoLoaiDeTai(b, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.RowCount > 0)
                {
                    txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtGVHuongDan.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
        }
        //1
        private void LoadDeTai()
        {
            cbbChonDeTai.ValueMember = "MaLoaiDT";
            cbbChonDeTai.DisplayMember = "TenLoaiDeTai";
            DataSet1.LoaiDTDataTable b = new DataSet1.LoaiDTDataTable();
            DataSet1TableAdapters.LoaiDTTableAdapter a = new DataSet1TableAdapters.LoaiDTTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonDeTai.DataSource = b;
        }

        private void cbbChonDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        //3
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDeTai.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txtGVHuongDan.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenDeTai.Clear();
            txtDiem.Clear();
            txtGVHuongDan.Clear();
            txtTenDeTai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataSet1.detaiDataTable b = new DataSet1.detaiDataTable();
            DataSet1TableAdapters.detaiTableAdapter a = new DataSet1TableAdapters.detaiTableAdapter();
            b.Reset();
            if (opt == "1")
            {
                a.ThemDeTai(b, txtTenDeTai.Text, double.Parse(txtDiem.Text), txtGVHuongDan.Text, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
            }
            else
            {
                //if (dataGridView1.RowCount > 1)
                //{
                    long MaDT = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    a.SuaDeTai(b, MaDT, txtTenDeTai.Text, double.Parse(txtDiem.Text), txtGVHuongDan.Text, int.Parse(cbbChonDeTai.SelectedValue.ToString()));
                    MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
                //}
            }
            LoadData();
        }
    }
}
