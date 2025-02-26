using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Optional_Parameter
{
    internal class Program
    {
        // Hàm tính diện tích hình chữ nhật với chiều rộng là tham số tùy chọn(mặc định bằng 10)
        static int TinhDienTich_147(int chieuDai_147, int chieuRong_147 = 10)
        {
            // Tính diện tích
            int dienTich_147 = chieuDai_147 * chieuRong_147;
            return dienTich_147;
        }

        static void Main(string[] args)
        {          
            Console.OutputEncoding = Encoding.UTF8;//Xuất chữ tiếng việt

            int chieuDai_147;
            int chieuRong_147;
            int tiepTuc = 1;
            while (tiepTuc == 1)
            {
                // Nhập chiều dài hình chữ nhật
                Console.Write("\nNhập chiều dài: ");
                while (!int.TryParse(Console.ReadLine(), out chieuDai_147) || chieuDai_147 <= 0)
                {
                    Console.Write("Chiều dài không hợp lệ! Nhập lại: ");
                }

                // Nhập chiều rộng hình chữ nhật
                Console.Write("Nhập chiều rộng (nhập tầm bậy để bỏ qua): ");
                string chieuRongString_147 = Console.ReadLine();

                if (!int.TryParse(chieuRongString_147, out chieuRong_147) || chieuRong_147 <= 0)
                {
                    // Gọi hàm với chỉ một tham số (dùng giá trị mặc định của chiều rộng)
                    double ketQua1_147 = TinhDienTich_147(chieuDai_147);
                    Console.WriteLine("\nChiều rộng mặc định = 10\nChiều dài = {0}\nDiện tích HCN = {1}", chieuDai_147, ketQua1_147);
                }
                else
                {
                    // Gọi hàm khi có chiều dài chiều rộng đầy đủ
                    double ketQua1_147 = TinhDienTich_147(chieuDai_147, chieuRong_147);
                    Console.WriteLine("\nChiều rộng = {0}\nChiều dài bằng {1}\nDiện tích HCN = {2}", chieuRong_147, chieuDai_147, ketQua1_147);
                }
                Console.WriteLine("\n===> Lựa chọn <===");
                Console.WriteLine("1. Tiếp tục");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("==================");               
                Console.Write("Chọn: ");
                while(!int.TryParse(Console.ReadLine(), out tiepTuc) || (tiepTuc != 1 && tiepTuc != 0))
                {
                    Console.Write("Lựa chọn không hợp lệ! Chọn lại: ");
                }
            };
            Console.Write("\nKết thúc chương trình!");
            Console.ReadKey();
        }
    }
}
