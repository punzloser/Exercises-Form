using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{


    class HoaDon
    {

        private float dongia;
        private int soluong;
        private string tenhang;
        private static int sohd;
        private static float doanhthu;

        public float Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Tenhang
        {
            get
            {
                return tenhang;
            }

            set
            {
                tenhang = value;
            }
        }

        public static int Sohd
        {
            get
            {
                return sohd;
            }

           
        }

        public static float Doanhthu
        {
            get
            {
                return doanhthu;
            }

            
        }

        public HoaDon()
        {
            this.tenhang = "";
            this.soluong = 0;
            this.dongia = 0;
            sohd = 0;
            doanhthu = 0;
        }
        public HoaDon(string _tenhang,int _solg, float _dongia)
        {
            tenhang = _tenhang;
            soluong = _solg;
            dongia = _dongia;

        } 

        public float Tinh()
        {
            float tt= soluong* dongia;
            HoaDon.sohd++;
            HoaDon.doanhthu += tt;
            return tt;
        }

        
    }
}
