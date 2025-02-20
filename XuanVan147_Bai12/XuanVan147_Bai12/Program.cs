using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xuất chữ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            double x_147;
            int n_147;
            double sum_147 = 0;

            // Thông tin sinh viên
            Console.WriteLine("Họ tên: Bùi Xuân Văn \nMsv: 22115053122147 \nLớp học phần: 224LTC03 (C# thứ 7 tiết 3-4)");
            //Đề bài
            Console.WriteLine("--------------\n Bài 12:Tính S(n) = x + x^2 + x^3 + … + x^n");

            // Nhập giá trị cho cơ số x
            Console.Write("Nhập giá trị cho cơ số x: ");
            while (!double.TryParse(Console.ReadLine(), out x_147))
            {
                Console.Write("Giá trị không hợp lệ! Vui lòng nhập lại x: ");
            }

            // Nhập giá trị số mũ n nguyên dương
            Console.Write("Nhập số nguyên dương n: ");
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 <= 0)
            {
                Console.Write("Giá trị không hợp lệ! Vui lòng nhập lại số nguyên dương n: ");
            }

            // Tính tổng S(n) = x + x^2 + x^3 + ... + x^n
            for (int i_147 = 1; i_147 <= n_147; i_147++)
            {
                sum_147 = sum_147 + Math.Pow(x_147, i_147);
            }

            // Xuất kết quả
            Console.WriteLine($"Tổng S({n_147}) = {sum_147}");

            // Dừng màn hình để xem kết quả
            Console.ReadLine();
        }
    }
}
