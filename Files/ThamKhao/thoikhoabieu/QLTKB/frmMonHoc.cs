﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTKB
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
        }
        public void Locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Môn";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Tên Môn";
            msds.Columns[1].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblMonHoc";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                string sql = "Select count(*) from tblMonHoc where MaMon=N'" + txtma.Text + "'";
                if (cn.LoadLable(sql) == "0")
                {
                    cn.ExcuteNonQuery("insert into tblMonHoc values(N'" + txtma.Text + "',N'" + txtten.Text + "')");
                    try
                    {
                        hienthi();
                        MessageBox.Show("Lưu Thành Công");
                    }
                    catch
                    {
                        MessageBox.Show("Lưu Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Này Đã Có");
                    txtma.Focus();
                }
            }
            else
            {
                cn.ExcuteNonQuery("update tblMonHoc set TenMon=N'" + txtten.Text + "' where MaMon=N'" + txtma.Text + "'");
                try
                {
                    hienthi();
                    MessageBox.Show("Sửa Thành Công");
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            txtma.Enabled = false;
            Un_locktex();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("delete tblMonHoc where MaMon=N'" + txtma.Text + "'");
            try
            {
                hienthi();
                MessageBox.Show("Xóa Thành Công");
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
        }

        private void fr_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
        }
    }
}
