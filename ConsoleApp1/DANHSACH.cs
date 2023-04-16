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
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                    case 'B':
                        {
  
                            ct = new CHUYENTIENSANGBANBE();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
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
                            ct.hamnap(ct.Sotien);
                            break;
                        }
                    case 'R':
                        {

                            ct = new NAPTIENAPP();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }// nap rut 


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
                            Console.WriteLine("{0,2}  -{1,10} {2,20} {3,20}", sv.Ten, sv.Sotien, sv.Conlai1, DateTime.Today);
                            break;
                        }
                    case 'N':
                        {

                            Console.WriteLine("  So tien nap | So tien hien tai | Gioi gian Nap");
                            foreach (NAPTIENAPP nt in listStaff.Values)
                            Console.WriteLine("{+1,10} {2,20} {3,20}",nt.Sotien, nt.Conlai1, DateTime.Today);
                            break;
                        }
                    case 'R':
                        {
                            Console.WriteLine("  So tien rut | So tien hien tai | Gioi gian Rut");
                            foreach (NAPTIENAPP nt in listStaff.Values)
                                Console.WriteLine("{-1,10} {2,20} {3,20}", nt.Sotien, nt.Conlai1, DateTime.Today);
                            break;
                        }
                }//END SWITCH
                CHUYENTIEN ct = null;
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }// lich su gd

        public void Thanhtoanhoadon()
        {
            char c = 'y';
            while (c == 'y')
            {
                CHUYENTIEN ct = null;
                char loai = ' ';
                Console.WriteLine("Chon dich vu");
                Console.WriteLine("1. Thanh toan  dien");
                Console.WriteLine("2. Thanh toan  nuoc");
                Console.WriteLine("3. Thanh toan  internet");
                Console.WriteLine("4. Thanh toan  Hoc phi");
                Console.WriteLine("5. Thanh toan truyen hinh");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case '1':
                        {

                            ct = new THANHTOANHOADON();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                    case '2':
                        {

                            ct = new THANHTOANHOADON();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                    case '3':
                        {

                            ct = new THANHTOANHOADON();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                    case '4':
                        {

                            ct = new THANHTOANHOADON();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                    case '5':
                        {

                            ct = new THANHTOANHOADON();
                            ct.nhap();
                            ct.hamrut(ct.Sotien);
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }// thanh toan hoa don
        public void Thongtincanhan()
        {
            char c = 'y';
            while (c == 'y')
            {
                CHUYENTIEN ct = null;
                char loai = ' ';
                Console.WriteLine("N. Nhap thong tin ca nhan");
                Console.WriteLine("X. Xem thong tin ca nhan");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'N':
                        {

                            ct = new THONGTINCANHAN();
                            ct.Nhap1();
                            break;
                        }
                    case 'X':
                        {
                            Console.WriteLine("  Ho va ten | Gioi tinh | Ngay sinh | CMDD | Noi cap | email | Dia chi | Nghe Nghiep");
                            foreach (CHUYENTIEN tt in listStaff.Values)
                            Console.WriteLine("{1,10} {2,20} {3,20} {4,20} {5,20} {6,20} {7,20} {8,20}  ", tt.Hoten, tt.Gioitinh, tt.Ngaysinh, tt.Cmnd, tt.Noi_cap,tt.Email,tt.Diachi,tt.Nghenghiep);
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Hoten, ct);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }

    }
}
