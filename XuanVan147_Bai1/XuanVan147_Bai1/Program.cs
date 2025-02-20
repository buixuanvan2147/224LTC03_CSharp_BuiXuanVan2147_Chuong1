using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tính S(n) = 1 + 2 +3 + ... + n

            //Xuất chữ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            int n_147;
            string N_147;
            bool kiemTra;

            // Kiểm tra nhập vào số nguyên n >= 1
            do
            {
                Console.Write("Nhập vào n >= 1: ");
                N_147 = Console.ReadLine();
                kiemTra = int.TryParse(N_147, out n_147);
                if (!kiemTra || n_147 < 1)
                {
                    Console.WriteLine("Giá trị của n không hợp lệ!");
                }
            }
            while (!kiemTra || n_147 < 1);

            // Tính tổng S(n) = 1 + 2 + ... + n
            int S_147 = 0;
            for (int i = 1; i <= n_147; i++)  // Bắt đầu từ 1 đến n_147
            {
                S_147 += i;
            }
            Console.WriteLine("Bùi Xuân Văn - 22115053122147");
            Console.WriteLine("Tổng S({0}) = {1}", n_147, S_147);
            Console.ReadLine();
        }
    }
}
