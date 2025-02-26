    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bai2_Enum
    {
        internal class Program
    {

        // Định nghĩa Enum WeekDays(Các ngày trong tuần)
        enum WeekDays
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }
        static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;//Xuat tieng viet

                // 1. In ra tất cả các giá trị Enum
                Console.WriteLine("All WeekDays:");
                foreach (string name in Enum.GetNames(typeof(WeekDays)))
                {
                    Console.WriteLine(" " + name);
                }

                int luaChon = -1;
                while (luaChon != 0){

                Console.WriteLine("\n===> Chọn cách lấy giá trị Enum <===");
                Console.WriteLine("1. Nhập số thứ tự để lấy tên ngày");
                Console.WriteLine("2. Nhập tên ngày để lấy số thứ tự");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("====================================");
                Console.Write("Nhập lựa chọn (1 hoặc 2): ");

                while(!int.TryParse(Console.ReadLine(), out luaChon) || (luaChon != 1 && luaChon != 2 && luaChon != 0)){
                    Console.Write("Lựa chọn không hợp lệ! Chọn lại: ");
                };

                switch (luaChon){
                        case 1:
                            //Nhập số thứ tự để lấy tên ngày
                            int viTri;
                            Console.Write("\nNhập số thứ tự (0-6): ");                      
                            while (!int.TryParse(Console.ReadLine(), out viTri) || viTri < 0 || viTri > 6)
                            {
                                Console.Write("Số không hợp lệ! Nhập lại: ");
                            }
                            Console.WriteLine("Ngày tương ứng: " + (WeekDays)viTri);
                            break;

                        case 2:
                            //Nhập tên ngày để lấy số thứ tự
                            Console.Write("\nNhập tên ngày (ví dụ: Monday): ");
                            string input = Console.ReadLine();
                            if (Enum.TryParse(input, true, out WeekDays dayEnum)) // IgnoreCase = true để không phân biệt hoa thường
                        {
                                Console.WriteLine("Số thứ tự của {0} là: {1} ", input, (int)dayEnum);
                            }
                            else
                            {
                                Console.WriteLine("Tên không hợp lệ!");
                            }
                            break;

                        case 0:
                            Console.WriteLine("\nKết thúc chương trình!");
                            break;

                }
                };           
        }
        }
    }
