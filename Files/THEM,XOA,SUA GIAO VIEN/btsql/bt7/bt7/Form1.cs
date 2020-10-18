using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt7
{
    public partial class Form1 : Form
    {
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuBangKhoa();
            LoadDuLieudataGridView();
        }
        //1.Load du lieu combox
        public void LoadDuLieuBangKhoa()
        {
            cbb_khoa.ValueMember = "MaKhoa";
            cbb_khoa.DisplayMember = "TenKhoa";
            DataSet1.khoaDataTable b = new DataSet1.khoaDataTable();
            DataSet1TableAdapters.khoaTableAdapter a = new DataSet1TableAdapters.khoaTableAdapter();
            b.Reset();
            a.Fill(b);
            cbb_khoa.DataSource = b;


        }
        //2. Load du lieu vào dataGrid View
        public void LoadDuLieudataGridView()
        {
            if (cbb_khoa.SelectedIndex >= 0)
            {
                DataSet1.giaovienDataTable b = new DataSet1.giaovienDataTable();
                DataSet1TableAdapters.giaovienTableAdapter a = new DataSet1TableAdapters.giaovienTableAdapter();
                b.Reset();
                a.giaovientheokhoa_select(b, short.Parse(cbb_khoa.SelectedValue.ToString()));
                dataGridView1.DataSource = b;

                if (dataGridView1.RowCount>0)
                {
                    txt_tengv.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();

                    txt_sdt.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();

                    txt_luong.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();


                }

            }


        }

        private void cbb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuLieudataGridView();
        }
        //3. Viết sự CellClick hiện thị dữ liệu lên các ô Text box.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tengv.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();

            txt_sdt.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();

            txt_luong.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
        }
        //4. Viết xử lý thêm mới
        private void btn_them_Click(object sender, EventArgs e)
        {
            opt = "1";
            txt_tengv.Clear();
            txt_luong.Clear();
            txt_sdt.Clear();
            txt_tengv.Focus();
        }
        //5. Viết xử lý Lưu cho phần thêm mới
        private void btn_luu_Click(object sender, EventArgs e)
        {
            DataSet1.giaovienDataTable b = new DataSet1.giaovienDataTable();
            DataSet1TableAdapters.giaovienTableAdapter a = new DataSet1TableAdapters.giaovienTableAdapter();
            b.Reset();
            if (opt=="1")
            {
                a.giaovien_insert(b, txt_tengv.Text, txt_sdt.Text, double.Parse(txt_luong.Text),short.Parse(cbb_khoa.SelectedValue.ToString()));

                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
            }
            else
            {
                if (dataGridView1.RowCount > 0)
                {
                    long magv= long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    a.giaovien_update(b,magv, txt_tengv.Text, txt_sdt.Text, double.Parse(txt_luong.Text), short.Parse(cbb_khoa.SelectedValue.ToString()));
                    MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
                }

            }


            LoadDuLieudataGridView();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            opt = "";
            LoadDuLieudataGridView();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.RowCount > 0)
            {
                DataSet1.giaovienDataTable b = new DataSet1.giaovienDataTable();
              DataSet1TableAdapters.giaovienTableAdapter a = new DataSet1TableAdapters.giaovienTableAdapter();
              b.Reset();
                long magv = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                a.giaovien_delete(b, magv);
                MessageBox.Show(b.Rows[0]["ErrMsg"].ToString());
                LoadDuLieudataGridView();
            }
        }
    }
}
