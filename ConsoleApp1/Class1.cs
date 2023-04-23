using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DANGNHAP : CHUYENTIEN
    {
        private int sdt;
        private string mk;

        protected int Sdt { get => this.sdt; set => this.sdt = value; }
        protected string Mk { get => this.mk; set => this.mk = value; }


        public DANGNHAP() : base()
        {

        }

        public DANGNHAP(int sdt, string mk) : base()
        {
            this.Sdt = sdt;
            this.Mk = mk;
        }

        public override void nhap()
        {
            Console.WriteLine("(so dien thoai) Dang Nhap :");
            this.sdt = int.Parse(Console.ReadLine());
            Console.WriteLine("Mat Khau: ");
            this.mk = Console.ReadLine();
        }


        
    }
}
