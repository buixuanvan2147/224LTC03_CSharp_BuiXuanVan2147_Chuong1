using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_KetHop_OptionalParameter_Enum
{
    internal class Program
    {        
        enum MenuDoUongEnum //Enum chứa tháng và số ngày tương ứng của tháng
        {
            CaPheSua = 25000,
            CaPheDen = 20000,
            TraSuaTranChau = 35000,
            TraChanh = 15000,
            NuocCam = 30000
        }

        static void xuatMenu() //Hàm xuất menu ra màn hình
        {
            //In hết menu đồ uống ra màn hình
            Console.WriteLine("========>>> MENU <<<========\n");
            foreach (MenuDoUongEnum doUong_147 in Enum.GetValues(typeof(MenuDoUongEnum)))
            {
                Console.WriteLine($" {doUong_147,-18}  {(int)doUong_147}\n");
            }
            Console.WriteLine("============================");
        }
        
        static bool nhapVaKiemTraDoUong(out MenuDoUongEnum doUong) // Hàm nhập và kiểm tra đồ uống gọi lại trong case1 và case2
        {
            while (true)
            {
                Console.Write("\nNhập tên đồ uống (hoặc 0 để quay lại): ");
                string tenDoUong = Console.ReadLine();

                if (tenDoUong == "0")
                {
                    doUong = 0; // Trả về giá trị mặc định
                    return false; // Người dùng muốn thoát
                }

                if (Enum.TryParse(tenDoUong, true, out doUong) && Enum.IsDefined(typeof(MenuDoUongEnum), doUong))
                {
                    return true; // Nhập thành công
                }

                Console.WriteLine("Tên đồ uống không hợp lệ! Vui lòng nhập lại.");
            }
        }

        static double tinhTongTienNuoc(int gia, int SoLuong, int mucGiamGia = 5) //tính tổng tiền áp dụng optional parameter đối với giảm giá
        {
            return gia * SoLuong * (double)(100 - mucGiamGia) / 100;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ tiếng Việt

            xuatMenu();

            int luaChon_147 = -1;
            while (luaChon_147 != 0)
            {

                Console.WriteLine("\n--- Chọn một cái đi bạn ---");
                Console.WriteLine("1. Nhập tên nước để xem giá");
                Console.WriteLine("2. Đặt nước");
                Console.WriteLine("3. Xem menu");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("----------------------------");
                Console.Write("Nhập lựa chọn (0 - 3): ");

                while (!int.TryParse(Console.ReadLine(), out luaChon_147) || luaChon_147 < 0 || luaChon_147 > 3)
                {
                    Console.Write("Lựa chọn không hợp lệ! Chọn lại: ");
                };

                switch (luaChon_147)
                {
                    case 1:
                        //Nhập tên nước để xem giá
                        if (nhapVaKiemTraDoUong(out MenuDoUongEnum doUong)) //gọi hàm nhập tên đồ uống
                        {
                            Console.WriteLine($"Giá của {doUong} là {(int)doUong} VNĐ");
                        }
                        break;

                    case 2:// Đặt nước
                        
                        //Khai báo biến
                        int soLuong_147;
                        string giamGia_147;
                        int mucGiamGia_147;
                        double thanhTien;

                        if (nhapVaKiemTraDoUong(out MenuDoUongEnum nuocDat))
                        {
                            //Nhập số lượng
                            Console.Write("Nhập số lượng: ");
                            while (!int.TryParse(Console.ReadLine(), out soLuong_147) || soLuong_147 <= 0)
                            {
                                Console.Write("Số lượng không hợp lệ! Nhập lại: ");
                            }

                            //Nhập giảm giá
                            Console.WriteLine("Giảm giá (có/không): ");
                            giamGia_147 = Console.ReadLine();
                            while (giamGia_147 != "có" && giamGia_147 != "không")
                            {
                                Console.Write("Xác nhận giảm giá không hợp lệ! Nhập lại (có/không): ");
                                giamGia_147 = Console.ReadLine();                                
                            }
                            
                            if(giamGia_147 == "có")
                            {                          
                                Console.WriteLine("Nhập mức giảm giá(VD: 10 - là 10%): ");
                                while (!int.TryParse(Console.ReadLine(), out mucGiamGia_147) || mucGiamGia_147 < 0 || mucGiamGia_147 > 100)
                                {
                                    Console.Write("Mức giảm giá không hợp lệ! Nhập lại (0-100): ");
                                }
                                //Gọi hàm tính tiền khi có giảm giá
                                thanhTien = tinhTongTienNuoc((int)nuocDat, soLuong_147, mucGiamGia_147);
                            }
                            else
                            {
                                //Gọi hàm tính tiền khi không có giảm giá
                                thanhTien = tinhTongTienNuoc((int)nuocDat, soLuong_147);
                            }
                            
                            //Xuất kết quả ra màn hình
                            Console.WriteLine($"Bạn đã đặt {soLuong_147} ly {nuocDat}. Tổng tiền: {thanhTien} VNĐ");
                        }                     
                        break;

                    case 3:
                        //Xuat menu ra man hinh
                        xuatMenu();
                        break;

                    case 0:
                        Console.WriteLine("\nCảm ơn quý khách!");
                        break;

                }
            };
        }
    }
}
