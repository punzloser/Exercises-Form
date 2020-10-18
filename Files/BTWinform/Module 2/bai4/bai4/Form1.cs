using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Tinh()
        {
            int intNamduong = Convert.ToInt32(txtNamduong.Text);
            string strCan ="";
            string strChi= "";

            switch (intNamduong % 10)
                {
                    case 0:
                        strCan = "Canh";
                        break;
                    case 1:
                        strCan = "Tân";
                        break;
                    case 2:
                        strCan = "Nhâm";
                        break;
                    case 3:
                        strCan = "Quý";
                        break;
                    case 4:
                        strCan = "Giáp";
                        break;
                    case 5:
                        strCan = "Ất";
                        break;
                    case 6:
                        strCan = "Bính";
                        break;
                    case 7:
                        strCan = "Đinh";
                        break;
                    case 8:
                        strCan = "Mậu";
                        break;
                    case 9:
                        strCan = "Kỷ";
                        break;
             }

            switch(intNamduong%12)
            {
                case 0:
                    strChi = "Thân";
                    break;
                case 1:
                    strChi = "Dậu";
                    break;
                case 2:
                    strChi = "Tuất";
                    break;
                case 3:
                    strChi = "Hợi";
                    break;
                case 4:
                    strChi = "Tí";
                    break;
                case 5:
                    strChi = "Sửu";
                    break;
                case 6:
                    strChi = "Dần";
                    break;
                case 7:
                    strChi = "Mẹo";
                    break;
                case 8:
                    strChi = "Thìn";
                    break;
                case 9:
                    strChi = "Tị";
                    break;
                case 10:
                    strChi = "Ngọ";
                    break;
                case 11:
                    strChi = "Mùi";
                    break;
            }

            if(intNamduong>0)
            {
                txtAmlich.Text = strCan + " " + strChi;
            }

        }
        private void btnDoi_Click(object sender, EventArgs e)
        {

            Tinh();
            
        }
    }
}
