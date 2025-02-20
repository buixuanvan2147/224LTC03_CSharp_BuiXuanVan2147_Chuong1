using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai56
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
            Console.WriteLine("--------------\nBài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không \n--------------");

            int n_147;
            int tongCacChuSo_147 = 0;
            List<int> listChuSoLe = new List<int>();

            Console.Write("Nhập n = ");

            //Kiểm tra tính hợp lệ của số nguyên n
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147 < 1)
            {
                Console.Write("Gía trị n không hợp lệ! Nhập lại số nguyên dương n: ");
            }

            //Giữ lại n_147 để xuất kết quả
            int temp_147 = n_147;

            //Kiem tra
            while (temp_147 > 0)
            {
                tongCacChuSo_147++;
                int chuSo_147 = temp_147 % 10;
                if (chuSo_147 % 2 != 0)
                {
                    listChuSoLe.Add(chuSo_147);//thêm chữ số lẻ vào list
                }
                temp_147 = temp_147 / 10;
            }

            //Xuất kết quả
            int dem_147 = listChuSoLe.Count;// đếm các chữ số lẻ
            if (dem_147 == 0)
            {
                Console.WriteLine("Số {0} không có chữ số lẻ nào", n_147);
            }
            else
            {
                if (tongCacChuSo_147 == dem_147)
                {
                    Console.WriteLine("Số {0} có toàn bộ là các chữ số lẻ",n_147);
                }
                else
                {
                    Console.WriteLine("Số {0} không phải có toàn là các chữ số lẻ \n Có {1} chữ số lẻ là các chữ số: {2}", n_147, dem_147, string.Join(" ", listChuSoLe));
                }
            }

            Console.ReadKey();

        }
    }
}
