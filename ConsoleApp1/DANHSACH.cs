using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DANHSACH
    {
        Dictionary<String, CHUYENTIEN> listStaff;
        public DANHSACH()
        {
            this.listStaff = new Dictionary<string, CHUYENTIEN>();
        }

      //  Dictionary<String, dangnhap> keyValuePairs;
      //  public DANHSACH()
      //  {
       //     this.keyValuePairs = new Dictionary<String, dangnhap>();
       // }


        public void dangnhapvao()
        {
            dangnhap ct = null;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("            DANG NHAP             ");
            
        }

        public void Nhapchuyentien()
        {
            char c = 'y';
            while (c == 'y')
            {
                CHUYENTIEN ct = null;
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (C) Chuyen khoan (B) chuyen khoan den ban be");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'C':
                        {
                            
                            ct = new CHUYENTIENDENNGANHANG();
                            ct.nhap();
                            ct.conlai();
                            break;
                        }
                    case 'B':
                        {
  
                            ct = new CHUYENTIENSANGBANBE();
                            ct.nhap();
                            ct.conlai();
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                    Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }//end nhap chuyen tien


        public void NhapNaprut()
        {
            char c = 'y';
            while (c == 'y')
            {
                CHUYENTIEN ct = null;
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (N) Nap tien vao app (R) Rut tien ve ngan hang");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'N':
                        {

                            ct = new NAPTIENAPP();
                            ct.nhap();
                            ct.conlai12();
                            break;
                        }
                    case 'R':
                        {

                            ct = new NAPTIENAPP();
                            ct.nhap();
                            ct.conlai();
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }// nap rut 




            public void lichsugd ()
        {
            Console.WriteLine("Nguoi nhan |  So tien chuyen | So tien hien tai | Gioi gian nhan");
            foreach (CHUYENTIEN ct in listStaff.Values)
                Console.WriteLine("{0,2}  -{1,10} {2,20} {3,20}", ct.Ten, ct.Sotien,ct.Conlai1, DateTime.Today);
        }//end lich su gd


        public void Lichsugd()
        {
            char c = 'y';
            while (c == 'y')
            {
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (C) Xem lich su chuyen tien (N) Xem lich su nap tien (R)Xem lich su Rut Tien");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'C':
                        {

                            Console.WriteLine("Nguoi nhan |  So tien chuyen | So tien hien tai | Gioi gian nhan");
                            foreach (CHUYENTIEN sv in listStaff.Values)
                            Console.WriteLine("{0,2}  -{1,10} {2,20} {3,20}", sv.Ten, sv.Sotien, sv.Khoandu1, DateTime.Today);
                            break;
                        }
                    case 'N':
                        {

                            Console.WriteLine("  So tien nap | So tien hien tai | Gioi gian Nap");
                            foreach (NAPTIENAPP nt in listStaff.Values)
                            Console.WriteLine("{+1,10} {2,20} {3,20}",nt.Sotien, nt.Khoandu1, DateTime.Today);
                            break;
                        }
                    case 'R':
                        {
                            Console.WriteLine("  So tien rut | So tien hien tai | Gioi gian Rut");
                            foreach (NAPTIENAPP nt in listStaff.Values)
                                Console.WriteLine("{-1,10} {2,20} {3,20}", nt.Sotien, nt.Khoandu1, DateTime.Today);
                            break;
                        }
                }//END SWITCH
                CHUYENTIEN ct = null;
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }// nap rut 
    }
}
