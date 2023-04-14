using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class THANHTOANHOADON : CHUYENTIEN
    {
        private string mahoadon;

        public string Mahoadon { get => this.mahoadon; set => this.mahoadon = value; }

        public THANHTOANHOADON():base()
        {

        }

        public THANHTOANHOADON(string mahoadon, int stk, float sotien, float conlai1)
                              : base()
        {
            this.mahoadon = mahoadon;
        }
        public override void nhap()
        {
            
            Console.Write("Nhap ma hoa don: ");
            this.mahoadon = Console.ReadLine();
            base.nhap();
        }

        public override void Xuat()
        {
            Console.Write("Dich" + this.mahoadon);
            base.Xuat();

        }
    }
    

}
