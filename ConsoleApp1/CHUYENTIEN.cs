using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class CHUYENTIEN
    {
        protected int stk;
        protected string ten;
        protected float sotien;
        protected string loinhan;
        private float khoandu = 500000;
        protected float conlai1;
        protected string hoten ;
        protected string gioitinh;
        protected DateTime ngaysinh;
        protected int cmnd;
        protected string noi_cap;
        protected string email;
        protected string diachi;
        protected string nghenghiep;



        public int Stk { get => this.stk; set => this.stk = value; }
        public string Ten { get => this.ten; set => this.ten = value; }
        public float Sotien { get => this.sotien; set => this.sotien = value; }
        public string Loinhan { get => this.loinhan; set => this.loinhan = value; }
        public float Conlai1 { get => this.conlai1; set => this.conlai1 = value; }
        public float Khoandu { get => this.khoandu; set => this.khoandu = value; }
        public string Hoten { get => this.hoten; set => this.hoten = value; }
        public string Gioitinh { get => this.gioitinh; set => this.gioitinh = value; }
        public DateTime Ngaysinh { get => this.ngaysinh; set => this.ngaysinh = value; }
        public int Cmnd { get => this.cmnd; set => this.cmnd = value; }
        public string Noi_cap { get => this.noi_cap; set => this.noi_cap = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Diachi { get => this.diachi; set => this.diachi = value; }
        public string Nghenghiep { get => this.nghenghiep; set => this.nghenghiep = value; }

        public CHUYENTIEN() { }

        public CHUYENTIEN(int stk, string ten, float sotien, string loinhan,float conlai1,float khoandu, string hoten, string gioitinh, DateTime ngaysinh, int cmnd, string noi_cap, string email, string diachi, string nghenghiep)
        {
            this.stk = stk;
            this.ten = ten;
            this.sotien = sotien;
            this.loinhan = loinhan;
            this.conlai1 = conlai1;
            this.khoandu = khoandu;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Noi_cap = noi_cap;
            this.Email = email;
            this.Diachi = diachi;
            this.Nghenghiep = nghenghiep;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Noi_cap = noi_cap;
            this.Email = email;
            this.Diachi = diachi;
            this.Nghenghiep = nghenghiep;

        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap so tai khoan");
            this.stk = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so tien: ");
            this.sotien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loi nhan: ");
            this.loinhan = Console.ReadLine();
        }

        public void hamrut(float sotien)
        {
            if (sotien > khoandu)
            {
                Console.WriteLine("So du khong du de rut tien!");
            }
            else
            {
                khoandu -= sotien;
                Console.WriteLine("Da rut {0} tu tai khoan.So du hien tai: {1}", sotien, khoandu);
                
            }
            
        }

        public void hamnap(float sotien)
        {
            khoandu += sotien;
            Console.WriteLine("Da nap {0} tu tai khoan.So du hien tai: {1}", sotien, khoandu);
            
        }

        public virtual void Xuat()
        {
            Console.WriteLine("so tai khoan" + this.stk);
            Console.WriteLine("Ten chu tai khoan" + this.ten);
            Console.WriteLine("So tien" + this.sotien);
            Console.WriteLine("Loi nhan" + this.loinhan);
        }

        public virtual void Nhap1()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            this.gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            this.ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chung minh nhan dan: ");
            this.cmnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap noi cap: ");
            this.noi_cap = Console.ReadLine();
            Console.WriteLine("Nhap email: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            this.diachi = Console.ReadLine();
            Console.WriteLine("Nhap nghe nghiep: ");
            this.nghenghiep = Console.ReadLine();
        }

        public virtual void Xuat1()
        {
            Console.WriteLine("Ho va ten: " + this.hoten);
            Console.WriteLine("Gioi tinh: " + this.gioitinh);
            Console.WriteLine("Ngay sinh: " + this.ngaysinh);
            Console.WriteLine("Chung minh nhan dan: " + this.cmnd);
            Console.WriteLine("Noi cap: " + this.noi_cap);
            Console.WriteLine("Email:" + this.email);
            Console.WriteLine("Dia chi: " + this.diachi);
            Console.WriteLine("Nghe nghiep: " + this.nghenghiep);
        }
    }
}
