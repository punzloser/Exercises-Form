using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Quản_Lý_Kho_Điện_Thoại
{
    public partial class FormQuanLyKhoDienThoai : Form
    {
        public FormQuanLyKhoDienThoai()
        {
            InitializeComponent();
        }
        string ChuoiKetNoi = "Data Source=(local);Initial Catalog=QuanLyKhoDienThoai;Integrated Security=True";
        string Lenh = "";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DocDuLieu;
        string Tam;
        private void FormQuanLyKhoDienThoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDienThoaiDataSet.HangSX' table. You can move, or remove it, as needed.
            this.hangSXTableAdapter.Fill(this.quanLyKhoDienThoaiDataSet.HangSX);
            Load1();
            
            KetNoi = new SqlConnection(ChuoiKetNoi);
        }
        void Load1()
        {
            comboBoxHang.Text = "";
            checkBoxCapNhatGia.Enabled = false;
            textBoxGia.Enabled = false;
            textBoxSoLuongTon.Enabled = false;
            buttonCapNhat.Enabled = false;
            buttonXoa.Enabled = false;
            checkBoxCapNhatGia.Checked = false;
        }
        private void comboBoxHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxHang.SelectedIndex.ToString());
            HienDuLieu();
        }
        void HienDuLieu()
        {
            listView.Items.Clear();
            KetNoi.Open();
            Lenh = @"SELECT       DienThoai.MaDienThoai, DienThoai.TenDienThoai, DienThoai.DonGia, DienThoai.TonKho, HangSX.TenHang
                     FROM         DienThoai INNER JOIN
                                  HangSX ON DienThoai.MaHang = HangSX.MaHang
                     WHERE        (HangSX.TenHang = N'" + comboBoxHang.Text + "')";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            DocDuLieu = ThucHien.ExecuteReader();
            int i = 0;
            while (DocDuLieu.Read())
            {
                listView.Items.Add(DocDuLieu[0].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[2].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[3].ToString());
                i++;
            }
            label4.Text = "Tổng Số Lượng Dòng Điện Thoại: " + i.ToString();
            KetNoi.Close();
        }
        private void listView_Click(object sender, EventArgs e)
        {
            checkBoxCapNhatGia.Enabled = true;
            textBoxGia.Enabled = true;
            textBoxSoLuongTon.Enabled = true;
            //buttonCapNhat.Enabled = true;
            buttonXoa.Enabled = true;
            checkBoxCapNhatGia.Checked = false;
            textBoxGia.Text = listView.SelectedItems[0].SubItems[2].Text;
            textBoxSoLuongTon.Text = listView.SelectedItems[0].SubItems[3].Text;
            Tam = listView.SelectedItems[0].SubItems[0].Text;
        }

        private void checkBoxCapNhatGia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCapNhatGia.Checked == true)
            {
                textBoxGia.ReadOnly = false;
                //textBoxSoLuongTon.ReadOnly = false;
                buttonCapNhat.Enabled = true;
            }
            else
            {
                textBoxGia.ReadOnly = true;
                //textBoxSoLuongTon.ReadOnly = true;
                buttonCapNhat.Enabled = false;
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            KetNoi.Open();
            Lenh = @"UPDATE      DienThoai
                     SET         DonGia = "+textBoxGia.Text+@"
                     WHERE       (MaDienThoai = N'" + Tam + "')";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienDuLieu();
            Load1();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            KetNoi.Open();
            Lenh = @"DELETE FROM DienThoai
                     WHERE  (MaDienThoai = N'"+Tam+"')";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienDuLieu();
            Load1();
        }
    }
}
