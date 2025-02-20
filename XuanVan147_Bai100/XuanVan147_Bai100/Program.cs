using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xuất chữ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // Thông tin sinh viên
            Console.WriteLine("Họ tên: Bùi Xuân Văn \nMsv: 22115053122147 \nLớp học phần: 224LTC03 (C# thứ 7 tiết 3-4)");
            //Đề bài
            Console.WriteLine("--------------\nBài 100: Viết chương trình giải phương trình bậc 2 \n--------------");

            // Khai báo biến
            double a_147, b_147, c_147;

            // Nhập hệ số a
            Console.Write("Nhập hệ số a: ");
            while (!double.TryParse(Console.ReadLine(), out a_147))
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại a: ");
            }

            // Nhập hệ số b
            Console.Write("Nhập hệ số b: ");
            while (!double.TryParse(Console.ReadLine(), out b_147))
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại b: ");
            }

            // Nhập hệ số c
            Console.Write("Nhập hệ số c: ");
            while (!double.TryParse(Console.ReadLine(), out c_147))
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại c: ");
            }

            // Giải phương trình bậc 2
            GiaiPTBac2(a_147, b_147, c_147);

            Console.ReadKey();
        }

        static void GiaiPTBac1(double b_147, double c_147)
        {
            if (b_147 == 0)
            {
                if (c_147 == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x_147 = -c_147 / b_147;
                Console.WriteLine("Phương trình có nghiệm duy nhất: x = {0}" , x_147);
            }
        }
        static void GiaiPTBac2(double a_147, double b_147, double c_147)
        {
            // Trường hợp a = 0 => Phương trình bậc 1
            if (a_147 == 0)
            {
                GiaiPTBac1(b_147, c_147);
            }
            else //a_147 khác 0
            {
                // Tính delta
                double delta = b_147 * b_147 - 4 * a_147 * c_147;

                // Xét các trường hợp của delta
                if (delta > 0)
                {
                    double x1 = (-b_147 + Math.Sqrt(delta)) / (2 * a_147);
                    double x2 = (-b_147 - Math.Sqrt(delta)) / (2 * a_147);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt:\n x1 = {0}\n x2 = {1}", x1, x2);
                }
                else if (delta == 0)
                {
                    double x = -b_147 / (2 * a_147);
                    Console.WriteLine("Phương trình có nghiệm kép: x = {0}",x);
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
        }
    }
}
