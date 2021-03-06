﻿using System;
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
            loadChonKhoa();
            loadForm();
        }

        private void loadChonKhoa()
        {
            cbbChonKhoa.ValueMember = "MaKhoa";
            cbbChonKhoa.DisplayMember = "TenKhoa";
            DataSet1.KhoaDataTable b = new DataSet1.KhoaDataTable();
            DataSet1TableAdapters.KhoaTableAdapter a = new DataSet1TableAdapters.KhoaTableAdapter();
            b.Reset();
            a.Fill(b);
            cbbChonKhoa.DataSource = b;
        }

        private void loadForm()
        {
            if (cbbChonKhoa.SelectedIndex >= 0)
            {
                DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
                DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
                b.Reset();
                a.ChonGVTheoKhoa(b, short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.Rows.Count > 0)
                {
                    txtTenGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtSoDT.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                    txtLuong.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                }
            }
            opt = "";
        }

        private void cbbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTenGV.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtSoDT.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtLuong.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenGV.Text = "";
            txtSoDT.Text = "";
            txtLuong.Text = "";
            opt = "1";
            txtTenGV.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1.GiaoVienDataTable b = new DataSet1.GiaoVienDataTable();
            DataSet1TableAdapters.GiaoVienTableAdapter a = new DataSet1TableAdapters.GiaoVienTableAdapter();
            b.Reset();

            if (opt == "1")
            {
                a.ThemGV(b, txtTenGV.Text, txtSoDT.Text, double.Parse(txtLuong.Text), short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            else
            {
                long MaGV = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.SuaGV(b, MaGV, txtTenGV.Text, txtSoDT.Text, double.Parse(txtLuong.Text), short.Parse(cbbChonKhoa.SelectedValue.ToString()));
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString(), "Thông báo");
            }
            loadForm();
        }
    }
}
