using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
        internal class THONGTINCANHAN : CHUYENTIEN
        {
        

        public  THONGTINCANHAN(): base()
        {

        }

        public THONGTINCANHAN(string hoten, string gioitinh, DateTime ngaysinh, int cmnd, string noi_cap, string email, string diachi, string nghenghiep)
                               :base ()
        {
            
        }

        public override void Nhap1()
        {
            base.Nhap1();
        }

        public override void Xuat1()
        {
            base.Xuat1();


        }
    }


}
