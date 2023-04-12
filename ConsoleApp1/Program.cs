using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static DANHSACH danhsach;
        static CHUYENTIEN CHUYENTIEN;

        static void Menu()
        {
            try
            {
                Console.WriteLine("Nhap tu 1-6 de thuc hien cac chuc nang sau: ");
                Console.WriteLine("1. Hien thi khoan du");
                Console.WriteLine("2. Chuyen tien");
                Console.WriteLine("3. Nap tien vao app");
                Console.WriteLine("4. Rut tien tu app sang ngan hang");
                Console.WriteLine("5. Thanh Toan hoa don");
                Console.WriteLine("6. Lich su giao dich");
                int menu = 0;
                menu= Convert.ToInt32(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        {
                            danhsach.conlai();
                            break;
                        }
                    case 2:
                        {
                            danhsach.Nhap();
                            break;
                        }
                    
                    default:
                        Console.WriteLine("Yeu cau nhap chuc nang menu  tu 1-5 ");
                        Menu();
                        break;
                }//end switch
            }catch(Exception ex)
            {
                Menu();
            }
        }

        static void Main(string[] args)
        {
            danhsach = new DANHSACH();
            char c = 'y';
            while (c== 'y')
            {
                Menu();
                Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                c= Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
    }
}
