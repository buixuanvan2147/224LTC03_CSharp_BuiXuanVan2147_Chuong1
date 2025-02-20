using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai89
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
            Console.WriteLine("--------------\nBài 89: Viết chương trình tính tổng các giá trị lẻ nguyên dương nhỏ hơn n \n--------------");

            int n_147;
            int tongSoLe = 0;
            Console.Write("Nhập số nguyên dương n: ");
            while(!int.TryParse(Console.ReadLine(), out n_147) || n_147 < 1)
            {
                Console.Write("Gía trị n không hợp lệ! Nhập lại n: ");
            }

            for (int i = 0; i < n_147; i++)
            {
                if (i % 2 != 0)
                    tongSoLe += i;
            } 

            Console.WriteLine("Tổng các số nguyên dương lẻ nhỏ hơn {0} = {1}", n_147, tongSoLe);

            Console.ReadKey();
        }
    }
}
