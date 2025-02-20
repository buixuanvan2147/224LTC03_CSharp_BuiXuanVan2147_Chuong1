using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai78
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
            Console.WriteLine("--------------\nBài 78: Liệt kê tất cả các ước số của số nguyên dương n \n--------------");

            int n_147;
            int dem_147 = 0; //  Đếm số lượng các ước số của n
            Console.Write("Nhập giá trị n: ");
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 <= 0)
            {
                Console.Write("Gía trị của n không hợp lệ! \nNhập lại số nguyên dương n: ");
            }

            Console.Write("Các ước số nguyên của {0} là: ", n_147);

            // Tìm ước số của n_147
            for (int i_147 = 1; i_147 <= n_147; i_147++)
            {
                if (n_147 % i_147 == 0) // Chia lấy dư == 0
                {
                    dem_147 ++;
                    Console.Write("{0} ", i_147);
                }
            }

            Console.WriteLine("\nCó tất cả {0} biến", dem_147);

            Console.ReadKey();
        }
    }
}
