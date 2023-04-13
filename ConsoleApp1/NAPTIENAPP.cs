using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NAPTIENAPP : CHUYENTIEN
    {
        private string nganhang;

        public string Nganhang { get => nganhang; set => nganhang = value; }

        public NAPTIENAPP() :base() { }

        public NAPTIENAPP(string nganhang,int stk, string ten, float sotien, float conlai1,float khoandu) 
                         : base() 
        {
            this.nganhang = nganhang;
        }

        public override void nhap()
        {
            Console.Write("Nhap ngan hang");
            this.nganhang = Console.ReadLine();
            base.nhap();
        }


        public override void Xuat()
        {
            Console.Write("Ngan hang: " + this.nganhang);
            base.Xuat();
        }


        


    }
}
