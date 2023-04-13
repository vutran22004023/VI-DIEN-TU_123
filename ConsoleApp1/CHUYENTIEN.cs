﻿using System;
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
        
        

        public int Stk { get => this.stk; set => this.stk = value; }
        public string Ten { get => this.ten; set => this.ten = value; }
        public float Sotien { get => this.sotien; set => this.sotien = value; }
        public string Loinhan { get => this.loinhan; set => this.loinhan = value; }
        public float Conlai1 { get => this.conlai1; set => this.conlai1 = value; }
        public float Khoandu { get => this.khoandu; set => this.khoandu = value; }

        public CHUYENTIEN() { }

        public CHUYENTIEN(int stk, string ten, float sotien, string loinhan,float conlai1,float khoandu)
        {
            this.stk = stk;
            this.ten = ten;
            this.sotien = sotien;
            this.loinhan = loinhan;
            this.conlai1 = conlai1;
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

        public void conlai()
        {
            
            conlai1 = Khoandu - Sotien;
            khoandu = conlai1;
            if (conlai1 < 0)
            {
                Console.WriteLine("Khoan du khong du de thuc hien giao dich");
            }
            else
            {
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine("Khoan du cua ban hien tai: " + this.conlai1);
            }
        }

        public void conlai12()
        {

            conlai1 = Khoandu + Sotien;
            khoandu = conlai1;
            if (conlai1 < 0)
            {
                Console.WriteLine("Khoan du khong du de thuc hien giao dich");
            }
            else
            {
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine("Khoan du cua ban hien tai: " + this.conlai1);
            }
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
