using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        string status;
        bool loading;
        string idCurrent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_ccb();
            load_data();
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            txtDongia.ReadOnly = true;
            txtSoton.ReadOnly = true;
            txtTensp.ReadOnly = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Load_ccb()
        {
            loading = false;
            DataSet1.loaispDataTable b = new DataSet1.loaispDataTable();
            DataSet1TableAdapters.loaispTableAdapter a = new DataSet1TableAdapters.loaispTableAdapter();
            b.Reset();
            a.Fill(b);
            comboBox1.DataSource = b;
            comboBox1.DisplayMember = "TenLoaiSP";
            comboBox1.ValueMember = "MaLoaiSP";
            loading = true;
        }

        private void load_data()
        {
            loading = false;
            DataSet1.sanphamDataTable b = new DataSet1.sanphamDataTable();
            DataSet1TableAdapters.sanphamTableAdapter a = new DataSet1TableAdapters.sanphamTableAdapter();
            b.Reset();
            a.Fill(b);
            dataGridView1.DataSource = b;
            loading = true;
        }

        private void ChonSPTheoLoai()
        {
            loading = false;
            DataSet1.spud_ChonSanPhamTheoLoaiDataTable b = new DataSet1.spud_ChonSanPhamTheoLoaiDataTable();
            DataSet1TableAdapters.spud_ChonSanPhamTheoLoaiTableAdapter a = new DataSet1TableAdapters.spud_ChonSanPhamTheoLoaiTableAdapter();
            b.Reset();
            a.Fill(b, short.Parse(comboBox1.SelectedValue.ToString()));
            dataGridView1.DataSource = b;
            loading = true;
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(loading)
                ChonSPTheoLoai();
        }

        private void ChonSPTheoMaSP()
        {
            if(dataGridView1.Rows.Count>0)
            {
                txtTensp.Text = dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString();
                txtDongia.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoton.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                idCurrent = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ChonSPTheoMaSP();
        }


        private void XoaSP(short id)
        {
            
            DataSet1.spud_XoaSanPhamDataTable b = new DataSet1.spud_XoaSanPhamDataTable();
            DataSet1TableAdapters.spud_XoaSanPhamTableAdapter a = new DataSet1TableAdapters.spud_XoaSanPhamTableAdapter();
            b.Reset();
            a.Fill(b,id);
        }

        private void ThemSP(string ten,float dg,int soton,short maloai)
        {
            DataSet1.spud_ThemSanPhamDataTable b = new DataSet1.spud_ThemSanPhamDataTable();
            DataSet1TableAdapters.spud_ThemSanPhamTableAdapter a = new DataSet1TableAdapters.spud_ThemSanPhamTableAdapter();
            b.Reset();
            a.Fill(b, ten, dg, soton, maloai);
        }
     
        private void SuaSP(short ma, string ten, float dg, int soton, short maloai)
        {
            DataSet1.spud_SuaSanPhamDataTable b = new DataSet1.spud_SuaSanPhamDataTable();
            DataSet1TableAdapters.spud_SuaSanPhamTableAdapter a = new DataSet1TableAdapters.spud_SuaSanPhamTableAdapter();
            b.Reset();
            a.Fill(b, ma, ten, dg, soton, maloai);
        }

      
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = "delete";
                      
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtDongia.ReadOnly = false;
            txtSoton.ReadOnly = false;
            txtTensp.ReadOnly = false;
            txtDongia.Clear();
            txtSoton.Clear();
            txtTensp.Clear();
            status = "add";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtDongia.ReadOnly = false;
            txtSoton.ReadOnly = false;
            txtTensp.ReadOnly = false;
            status = "edit";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case "delete":
                    {
                        XoaSP(short.Parse(idCurrent));
                        MessageBox.Show("Xóa thành công!");
                    }
                    break;

                case "add":
                    {
                        ThemSP(txtTensp.Text, float.Parse(txtDongia.Text), int.Parse(txtSoton.Text), short.Parse(comboBox1.SelectedValue.ToString()));
                        MessageBox.Show("Thêm thành công!");
                    }
                    break;
                case "edit":
                    {
                        SuaSP(short.Parse(idCurrent), txtTensp.Text, float.Parse(txtDongia.Text), int.Parse(txtSoton.Text), short.Parse(comboBox1.SelectedValue.ToString()));
                        MessageBox.Show("Sửa thành công!");
                    }
                    break;
            }
            ChonSPTheoLoai();
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            txtDongia.ReadOnly = true;
            txtSoton.ReadOnly = true;
            txtTensp.ReadOnly = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}
