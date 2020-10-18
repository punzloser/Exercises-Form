using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
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
            enableButton(false);
        }

        private void enableButton (bool status)
        {
            btnInHoa.Enabled = status;
            btnInThuong.Enabled = status;
            btnDemChuThuong.Enabled = status;
            btnDemChuHoa.Enabled = status;
            btnDemSoTuMoiDong.Enabled = status;
            btnDemSoTu.Enabled = status;
            btnInNguyenPhuAm.Enabled = status;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
            enableButton(true);
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            txtXuat.Text = txtNhap.Text.ToUpper();
            enableButton(false);
        }

        private void btnInThuong_Click(object sender, EventArgs e)
        {
            txtXuat.Text = txtNhap.Text.ToLower();
            enableButton(false);
        }

        private void btnDemChuThuong_Click(object sender, EventArgs e)
        {
            int count = 0;
            string Input = txtNhap.Text;
            for (int i = 0; i< Input.Length; i++)
            {
                if (char.IsLower(Input[i])) count++;
            }
            txtXuat.Text = count.ToString();
        }

        private void btnDemChuHoa_Click(object sender, EventArgs e)
        {
            int count = 0;
            string Input = txtNhap.Text;
            for (int i = 0; i < Input.Length; i++)
            {
                if (char.IsUpper(Input[i])) count++;
            }
            txtXuat.Text = count.ToString();
        }

        private void btnDemSoTuMoiDong_Click(object sender, EventArgs e)
        {
            int count = txtNhap.Text.Split().Length;
            txtXuat.Text = "Số từ trong 1 dòng :" + count.ToString();
        }

        private void btnDemSoTu_Click(object sender, EventArgs e)
        {
            int count = txtNhap.Text.Split().Length;
            txtXuat.Text = "Số từ trong 1 dòng :" + count.ToString();
        }

        private void btnInNguyenPhuAm_Click(object sender, EventArgs e)
        {
            int countNguyenAm = 0;
            int countPhuAm = 0;
            string Input = txtNhap.Text;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Equals('u') || Input[i].Equals('e') || Input[i].Equals('o') || Input[i].Equals('a') || Input[i].Equals('i'))
                {
                    countNguyenAm++;
                } else if (!Input[i].Equals(' '))
                {
                    countPhuAm++;
                }
            }
            txtXuat.Text = "Nguyên âm:" + countNguyenAm.ToString() + "\nPhụ âm:" + countPhuAm.ToString() ;

        }
    }
}
