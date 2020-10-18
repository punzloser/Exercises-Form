using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {

        #region Khai báo mảng toàn cục
        const int MAX_SIZE = 10;
        int[] intMyArray;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtMang.Clear();
            this.NhapMang();
            this.XuatMang(intMyArray);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Khởi tạo mảng
            intMyArray = new int[MAX_SIZE];
            #endregion
        }
        private void NhapMang()
        {
            Random r = new Random();
            for (int i = 0; i < intMyArray.Length; i++)
                intMyArray[i] = r.Next(1, 11);
        }
        private void XuatMang(int[] a)
        {
            for(int i =0;i<intMyArray.Length;i++)
            {
                txtMang.Text += " " + a[i].ToString();
            }
        }
        private int TongMang(int[] a )
        {
            int kq = 0;
            for (int i = 0; i < intMyArray.Length; i++)
                kq += a[i];
            return kq;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = "Tổng mảng = " + TongMang(intMyArray).ToString();
        }

        private void btnDemle_Click(object sender, EventArgs e)
        {
            int n = 0;
            for(int i = 0; i<intMyArray.Length;i++)
            {
                if(intMyArray[i]%2==1)
                {
                     n += 1;
                }
            }

            txtKetqua.Text = "Số phần tử lẻ: " + n;
        }

        private void btnTongle_Click(object sender, EventArgs e)
        {
            int kq = 0;
            for (int i = 0; i < intMyArray.Length; i++)
            {
                if (intMyArray[i] % 2 == 1)
                {
                    kq += intMyArray[i];
                }
            }
            txtKetqua.Text = "Tổng số lẻ trong mảng là: " + kq;
        }

        private int SoNhoNhat(int[] a)
        {
            txtKetqua.Clear();
            int min=intMyArray[0];
            for (int i = 0; i < intMyArray.Length; i++)
            { 
                     if (min > intMyArray[i] )
                    min = intMyArray[i];
                  }
            return min;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = "Số nhỏ nhất là: " + SoNhoNhat(intMyArray).ToString();
        }

        private void Tang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += 2;
            }
        }
        private void btnTang2_Click(object sender, EventArgs e)
        {
            txtKetqua.Clear();
            Tang(intMyArray);
            for (int i = 0; i < intMyArray.Length; i++)
            {
                txtKetqua.Text += " " + intMyArray[i].ToString();
            }
        }

       
        private void btnTang_Click(object sender, EventArgs e)
        {
            txtKetqua.Clear();
            for (int i = 0; i < intMyArray.Length - 1; i++)
                for (int j = i+1; j < intMyArray.Length; j++)
                {
                    if(intMyArray[i]>intMyArray[j])
                    {
                        int a = intMyArray[i];
                        intMyArray[i] = intMyArray[j];
                        intMyArray[j] = a;
                    }
                }
            for (int i = 0; i < intMyArray.Length; i++)
            {
                txtKetqua.Text += " " + intMyArray[i].ToString();
            }

        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            txtKetqua.Clear();
            for (int i = 0; i < intMyArray.Length - 1; i++)
                for (int j = i + 1; j < intMyArray.Length; j++)
                {
                    if (intMyArray[i] < intMyArray[j])
                    {
                        int a = intMyArray[i];
                        intMyArray[i] = intMyArray[j];
                        intMyArray[j] = a;
                    }
                }
            for (int i = 0; i < intMyArray.Length; i++)
            {
                txtKetqua.Text += " " + intMyArray[i].ToString();
            }
        }
    }
}
