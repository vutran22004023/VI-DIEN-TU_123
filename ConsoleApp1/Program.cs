using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static DANHSACH danhsach;


        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\x1b[32m\x1b[3m                     MEMEPAY                       \x1b[0m");
                Console.WriteLine("\x1b[96m-----------------------------------------------");
                Console.WriteLine("| Nhap tu 1-6 de thuc hien cac chuc nang sau: |");
                Console.WriteLine("| 1. Chuyen tien                              |");
                Console.WriteLine("| 2. Nap tien/rut vao app                     |");
                Console.WriteLine("| 3. Thanh Toan hoa don                       |");
                Console.WriteLine("| 4. Lich su giao dich                        |");
                Console.WriteLine("| 5. Thong tin ca nhan                        |");
                Console.WriteLine("-----------------------------------------------\x1b[0m");
                int menu = 0;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            danhsach.Nhapchuyentien();
                            break;
                        }
                    case 2:
                        {
                            danhsach.NhapNaprut();
                            break;
                        }

                    case 3:
                        {
                            danhsach.Thanhtoanhoadon();
                            break;
                        }

                    case 4:
                        {
                            danhsach.Lichsugd();
                            break;
                        }
                    case 5:
                        {
                            danhsach.Thongtincanhan();
                            break;
                        }

                    default:
                        Console.WriteLine("Yeu cau nhap chuc nang menu  tu 1-5 ");
                        Menu();
                        break;
                }//end switch
            }
            catch (Exception ex)
            {
                Menu();
            }
        }

        static void Main(string[] args)
        {
            
            danhsach = new DANHSACH();
            danhsach.dangnhapvao();
            char c = 'y';
            while (c == 'y')
            {
                Menu();
                Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
    }
}
