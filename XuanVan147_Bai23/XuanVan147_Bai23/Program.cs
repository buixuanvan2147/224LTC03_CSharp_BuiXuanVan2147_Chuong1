using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XuanVan147_Bai23
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
            Console.WriteLine("--------------\nBài 23: Đếm số lượng “ước số” của số nguyên dương n");

            int n_147;
            Console.Write("Nhập giá trị n: ");
            while (!int.TryParse(Console.ReadLine(), out n_147) || n_147<= 0)
            {
                Console.Write("Gía trị của n không hợp lệ! \nNhập lại số nguyên dương n: ");
            }

            // List lưu các ước số của n
            List<int> uocSoList_147 = new List<int>(); 

            // Tìm ước số của n_147
            for (int i_147 = 1; i_147 <= n_147; i_147++)
            {
                if (n_147 % i_147 == 0) // Chia lấy dư == 0
                {
                    uocSoList_147.Add(i_147); // Thêm vào danh sách
                }
            }

            //  Đếm số lượng các ước số của n
            int dem_147 = 0;
            dem_147 = uocSoList_147.Count;

            // Xuất kết quả ra màn hình
            //string.Join(" ", uocSoList_147) => ghép các phần tử của list thành chuỗi cách nhau bởi kí tự trắng " "
            Console.WriteLine("Các ước số nguyên của {0} là: {1}", n_147, string.Join(" ", uocSoList_147));
            Console.WriteLine("Số lượng “ước số” của số nguyên dương {0} là: {1}", n_147, dem_147);
            Console.ReadKey();
        }
    }
}
