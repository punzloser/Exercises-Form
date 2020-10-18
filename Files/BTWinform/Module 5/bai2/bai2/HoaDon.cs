using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HoaDon
    {
        private string hoten,diachi,dienthoai;
        private float giatien,thue;
        private bool mauxe;
        private static int sokh, sokhden;
        private static float doanhthu;

        public HoaDon(string hoten, string diachi, string dienthoai, float giatien, bool mauxe,float thue)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.giatien = giatien;
            this.thue = thue;
            this.mauxe = mauxe;
            

        }

        public HoaDon()
        {
            this.hoten = "";
            this.diachi = "";
            this.dienthoai = "";
            this.giatien = 0;
            this.thue = 0;
            this.mauxe = true;
            sokh = 0;
            sokhden = 0;
            doanhthu = 0;
        }

        public static int Sokh
        {
            get
            {
                return sokh;
            }
        }
        public static int  Sokhden
        {
            get
            {
            return sokhden;
            }
        }

        public static float Doanhthu
        {
            get
            {
                return doanhthu;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Dienthoai
        {
            get
            {
                return dienthoai;
            }

            set
            {
                dienthoai = value;
            }
        }

        public float Giatien
        {
            get
            {
                return giatien;
            }

            set
            {
                giatien = value;
            }
        }

        public float Thue
        {
            get
            {
                return thue;
            }

            set
            {
                thue = value;
            }
        }

        public bool Mauxe
        {
            get
            {
                return mauxe;
            }

            set
            {
                mauxe = value;
            }
        }

        public float PhuThu()
        {
            float gt;
            if (this.mauxe == true)
            {
               gt = (this.giatien * (float)0.05);

            }
            else
            {
               gt= 0;

            }
            return gt;
        }

        public float thanhtien()
        {
            float tt = (giatien + PhuThu() + thue);
            HoaDon.sokh += 1;
            if (this.mauxe == true)
                HoaDon.sokhden++;
            HoaDon.doanhthu += tt;
            return tt;

        }

    }
}
