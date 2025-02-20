using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai34
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
            Console.WriteLine("--------------\nBài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn \n--------------");

            int n_147;
            double s_147 = 0;
            Console.Write("Nhập n = ");
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 < 1)
            {
                Console.Write("Gía trị n không hợp lệ! Nhập lại số nguyên dương n: ");
            }

            //Tính từ trong ra ngoài, đi từ 1 đến n_147
            for (int i_147 = 1; i_147 <= n_147; i_147++)
            {
                s_147 = Math.Sqrt(i_147 + s_147);
            }

            Console.WriteLine("S({0}) = {1}", n_147, s_147);

            Console.ReadKey();
        }
    }
}
