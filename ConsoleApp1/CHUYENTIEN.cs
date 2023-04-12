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
        protected float sotien = 0;
        protected string loinhan;
        private float khoandu = 500000;



        public int Stk { get => this.stk; set => this.stk = value; }
        public string Ten { get => this.ten; set => this.ten = value; }
        public float Sotien { get => this.sotien; set => this.sotien = value; }
        public string Loinhan { get => this.loinhan; set => this.loinhan = value; }
        public float Khoandu { get => this.khoandu; set => this.khoandu = value; }

        public CHUYENTIEN() { }

        public CHUYENTIEN(int stk, string ten, float sotien, string loinhan,float khoandu)
        {
            this.stk = stk;
            this.ten = ten;
            this.sotien = sotien;
            this.loinhan = loinhan;
            this.khoandu = khoandu;
            
        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap so tai khoan");
            this.stk = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so tien");
            this.sotien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loi nhan: ");
            this.loinhan = Console.ReadLine();
        }


        public virtual void Xuat()
        {
            Console.WriteLine("so tai khoan" + this.stk);
            Console.WriteLine("Ten chu tai khoan" + this.ten);
            Console.WriteLine("So tien" + this.sotien);
            Console.WriteLine("Loi nhan" + this.loinhan);
        }

    }
}
