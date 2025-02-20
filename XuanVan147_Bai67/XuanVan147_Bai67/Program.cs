using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai67
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
            Console.WriteLine("--------------\nBài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n \n--------------");

            // Khai báo biến
            double x_147;
            int n_147;
            double tongS_147 = 0; // Tổng S(x, n)

            // Nhập cơ số x
            Console.Write("Nhập giá trị x: ");
            while (!double.TryParse(Console.ReadLine(), out x_147))
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại x: ");
            }

            // Nhập số nguyên dương n
            Console.Write("Nhập số nguyên dương n: ");
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 < 1)
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại n (nguyên dương): ");
            }

            // Tính S(x, n)
            for (int i = 1; i <= n_147; i++)
            {
                if(i % 2 != 0) {
                    tongS_147 = tongS_147 + Math.Pow(x_147, i);
                }
                else {
                    tongS_147 = tongS_147 + Math.Pow(x_147, i);
                }
            }

            // Xuất kết quả
            Console.WriteLine($"Giá trị của S({x_147}, {n_147}) = {tongS_147}");

            Console.ReadKey();

        }
    }
}
