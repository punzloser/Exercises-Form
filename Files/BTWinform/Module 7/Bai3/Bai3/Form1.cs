using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        string status;
        bool isLoading;
        string idCurrentGV;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initCombox();
            initTable();
            setTextboxEnable(false);
            setPanel1Enable(true);
            setPanel2Enable(false);
        }

        private void initCombox()
        {
            isLoading = false;
            DataSet1.khoaDataTable b = new DataSet1.khoaDataTable();
            DataSet1TableAdapters.khoaTableAdapter a = new DataSet1TableAdapters.khoaTableAdapter();
            b.Reset();
            a.Fill(b);
            cbKhoa.DataSource = b;
            cbKhoa.DisplayMember = "tenkhoa";
            cbKhoa.ValueMember = "makhoa";
            isLoading = true;
        }

        private void loadData2TextBox()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtName.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtPhone.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSalary.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                idCurrentGV = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void setTextboxEnable(bool status)
        {
            txtName.Enabled = status;
            txtPhone.Enabled = status;
            txtSalary.Enabled = status;
        }
        
        private void setPanel1Enable(bool status)
        {
            btnThem.Enabled = status;
            btnXoa.Enabled = status;
            btnSua.Enabled = status;
        }

        private void setPanel2Enable(bool status)
        {
            btnLuu.Enabled = status;
            btnHuy.Enabled = status;
        }

        private void initTable()
        {
            isLoading = false;
            DataSet1.spud_ChonGiaoVienTheoKhoaDataTable b = new DataSet1.spud_ChonGiaoVienTheoKhoaDataTable();
            DataSet1TableAdapters.spud_ChonGiaoVienTheoKhoaTableAdapter a = new DataSet1TableAdapters.spud_ChonGiaoVienTheoKhoaTableAdapter();
            b.Reset();
            a.Fill(b, short.Parse(cbKhoa.SelectedValue.ToString()));
            dataGridView1.DataSource = b;
            isLoading = true;

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                initTable();
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "add";
            btnThem.Enabled = true;
            setTextboxEnable(true);
            setPanel1Enable(false);
            setPanel2Enable(true);
            txtName.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setTextboxEnable(false);
            setPanel1Enable(true);
            setPanel2Enable(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            status = "delete";
            setTextboxEnable(true);
            setPanel1Enable(false);
            setPanel2Enable(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            status = "update";
            setTextboxEnable(true);
            setPanel1Enable(false);
            setPanel2Enable(true);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            loadData2TextBox();
        }

        private void addGiaoVien(string name, string phone, float salary, short makhoa)
        {
            DataSet1.spud_ThemGiaoVienDataTable b = new DataSet1.spud_ThemGiaoVienDataTable();
            DataSet1TableAdapters.spud_ThemGiaoVienTableAdapter a = new DataSet1TableAdapters.spud_ThemGiaoVienTableAdapter();
            b.Reset();
            a.Fill(b, name, phone, salary, makhoa);
        }

        private void editGiaoVien(long id, string name, string phone, float salary, short makhoa)
        {
            DataSet1.spud_SuaGiaoVienDataTable b = new DataSet1.spud_SuaGiaoVienDataTable();
            DataSet1TableAdapters.spud_SuaGiaoVienTableAdapter a = new DataSet1TableAdapters.spud_SuaGiaoVienTableAdapter();
            b.Reset();
            a.Fill(b, id, name, phone, salary, makhoa);
        }

        private void deleteGiaoVien(long id)
        {
            DataSet1.spud_XoaGiaoVienDataTable b = new DataSet1.spud_XoaGiaoVienDataTable();
            DataSet1TableAdapters.spud_XoaGiaoVienTableAdapter a = new DataSet1TableAdapters.spud_XoaGiaoVienTableAdapter();
            b.Reset();
            a.Fill(b, id);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case "add":
                    {
                        addGiaoVien(txtName.Text, txtPhone.Text, float.Parse(txtSalary.Text), short.Parse(cbKhoa.SelectedValue.ToString()));
                        MessageBox.Show("Thêm thành công!");
                    }
                    break;
                case "update":
                    {
                        editGiaoVien(long.Parse(idCurrentGV), txtName.Text, txtPhone.Text, float.Parse(txtSalary.Text), short.Parse(cbKhoa.SelectedValue.ToString()));
                        MessageBox.Show("Sửa thành công!");
                    }
                    break;
                case "delete":
                    {
                        deleteGiaoVien(long.Parse(idCurrentGV));
                        MessageBox.Show("Xoá thành công!");
                    }
                    break;
            }
            initTable();
            setTextboxEnable(false);
            setPanel1Enable(true);
            setPanel2Enable(false);
        }
    }
}
