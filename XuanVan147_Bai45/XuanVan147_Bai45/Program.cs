using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai45
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
            Console.WriteLine("--------------\nBài 45: Hãy tính tích các chữ số của số nguyên dương n \n--------------");

            int n_147;
            double tichCacChuSo_147 = 1; //Tích các chữ số của n_147
            Console.Write("Nhập n = ");

            //Kiểm tra tính hợp lệ của số nguyên n
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 < 1)
            {
                Console.Write("Gía trị n không hợp lệ! Nhập lại số nguyên dương n: ");
            }

            //Giữ lại n_147 để xuất kết quả
            int temp_147 = n_147;

            //Tính tích các số nguyên dương n
            while (temp_147 > 0)
            {
                tichCacChuSo_147 = tichCacChuSo_147 * (temp_147 % 10);
                temp_147 = temp_147 / 10;
            }

            //Xuất kết quả
            Console.WriteLine("Tích các chữ số của {0} bằng {1}", n_147, tichCacChuSo_147);

            Console.ReadKey();
        }
    }
}
