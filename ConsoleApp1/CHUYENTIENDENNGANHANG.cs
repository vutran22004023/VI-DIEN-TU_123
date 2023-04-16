using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class CHUYENTIENDENNGANHANG:CHUYENTIEN
    {
        private string nganhang;

        public string Nganhang { get => this.nganhang; set => this.nganhang = value; }

        public CHUYENTIENDENNGANHANG() : base()
        {

        }

        public CHUYENTIENDENNGANHANG(string nganhang, int stk, string ten, float sotien, string loinhan,float khoandu,float conlai1, string hoten, string gioitinh, DateTime ngaysinh, int cmnd, string noi_cap, string email, string diachi, string nghenghiep)
                               :base (stk,ten,sotien,loinhan,khoandu,conlai1,hoten,gioitinh,ngaysinh,cmnd,noi_cap,email,diachi,nghenghiep)
        {
            this.nganhang = nganhang;
        }

        public override void nhap()
        {
            Console.Write("Nhap ngan hang: ");
            this.nganhang = Console.ReadLine();
            base.nhap();
        }

        public override void Xuat()
        {
            Console.Write("Ngan hang" + this.nganhang);
            base.Xuat();

        }
    }
}
