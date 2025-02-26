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

                Console.WriteLine("===> Chọn cách lấy giá trị Enum <===");
                Console.WriteLine("1. Nhập số thứ tự để lấy tên ngày");
                Console.WriteLine("2. Nhập tên ngày để lấy số thứ tự");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("====================================");
                Console.Write("Nhập lựa chọn (1 hoặc 2): ");

                while(!int.TryParse(Console.ReadLine(), out luaChon) || (luaChon != 1 && luaChon != 2 && luaChon != 0)){
                    Console.Write("Lựa chọn không hợp lệ! Chọn lại: ");
                };

                switch (luaChon){
                        case '1':
                        //Nhập số thứ tự để lấy tên ngày
                        break;

                        case '2':
                        //Nhập tên ngày để lấy số thứ tự
                        break;

                        case '0':
                            Console.WriteLine("\nKết thúc chương trình!");
                            break;

                }
                };

                // 2. Lấy tên của một giá trị Enum cụ thể
                Console.WriteLine("\nDay at index 4: " + Enum.GetName(typeof(WeekDays), 4));

                // 3. Chuyển đổi chuỗi thành giá trị Enum
                WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), "Friday");
                Console.WriteLine("\nParsed from string: " + day);

                // 4. Dùng TryParse để tránh lỗi khi chuyển đổi chuỗi không hợp lệ
                if (Enum.TryParse("Holiday", out WeekDays invalidDay))
                {
                    Console.WriteLine("\nParsed successfully: " + invalidDay);
                }
                else
                {
                    Console.WriteLine("\nInvalid Enum value: 'Holiday'");
                }
        }
        }
    }
