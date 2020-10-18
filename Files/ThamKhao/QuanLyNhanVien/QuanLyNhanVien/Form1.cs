using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
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
            Load_data();
        }

        public void Load_data()
        {
            DataSet1.NhanVienDataTable b = new DataSet1.NhanVienDataTable();
            DataSet1TableAdapters.NhanVienTableAdapter a = new DataSet1TableAdapters.NhanVienTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;
            if (dataGridView1.Rows.Count > 0)
            {
                //Gán dữ liệu từ lưới lên Textbox
                txtTenNV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoDienThoai.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            opt = "";
            txtTenNV.Focus();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            opt = "1";
            txtTenNV.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenNV.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.NhanVienDataTable b = new DataSet1.NhanVienDataTable();
            DataSet1TableAdapters.NhanVienTableAdapter a = new DataSet1TableAdapters.NhanVienTableAdapter();
            b.Reset();
            if (opt == "1")
            {
                
                a.nhanvien_them(b, txtTenNV.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());

            }
            else
            {
                int id= int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

                a.nhanvien_sua(b, id, txtTenNV.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());    


            }

            Load_data();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataSet1.NhanVienDataTable b = new DataSet1.NhanVienDataTable();
            DataSet1TableAdapters.NhanVienTableAdapter a = new DataSet1TableAdapters.NhanVienTableAdapter();
            b.Reset();
            int id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            a.nhanvien_xoa(b,id);
            MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
            Load_data();
        }   

        private void btnHuy_Click(object sender, EventArgs e)
        {
            opt = "";          


            Load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //Gán dữ liệu từ lưới lên Textbox
                txtTenNV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoDienThoai.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
