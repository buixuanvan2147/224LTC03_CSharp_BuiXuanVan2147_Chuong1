using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiXuanVan147_BaiTapOOP
{
    //Interface IEmployee_147 chứa phương thức chung cho nhân viên
    public interface IEmployee_147
    {
        int CalculateSalary_147(); //Phương thức tính lương cho nhân viên
        string GetName_147(); //Phương thức lấy tên nhân viên
    }

    //Abstract class Employee_147 kế thừa Interface IEmployee_147, lưu thông tin chung của nhân viên
    public abstract class Employee_147 : IEmployee_147
    {
        protected string name_147; //Tên nhân viên
        protected int paymentPerHour_147; //Lương làm việc trên mỗi giờ

        //Khởi tạo Constructor
        public Employee_147(string name_147, int paymentPerHour_147)
        {
            this.name_147 = name_147;
            this.paymentPerHour_147 = paymentPerHour_147;
        }

        //Phương thức set tên nhân viên
        public void SetName_147(string name_147)
        {
            this.name_147 = name_147;
        }

        // Phương thức get tên nhân viên

        public string GetName_147()
        {
            return this.name_147;
        }

        //Phương thức set tiền lương mỗi giờ
        public void SetPaymentPerHour_147(int paymentPerHour_147)
        {
            this.paymentPerHour_147 = paymentPerHour_147;
        }

        // Phương thức get tiền lương mỗi giờ
        public int GetPaymentPerHour_147()
        {
            return this.paymentPerHour_147;
        }

        // Phương thức tính lương để gọi lại ở các class con
        public abstract int CalculateSalary_147();
    }

    // Class con PartTimeE conmployee_147 kế thừa từ Employee_147 (Nhân viên bán thời gian)
    public class PartTimeEmployee_147 : Employee_147
    {
        private int workingHours_147; // Số giờ làm việc mỗi ngày

        // Constructor khởi tạo giá trị
        public PartTimeEmployee_147(string name_147, int paymentPerHour_147, int workingHours_147)
            : base(name_147, paymentPerHour_147)
        {
            this.workingHours_147 = workingHours_147;
        }

        // Phương thức set số giờ làm việc
        public void SetWorkingHours_147(int workingHours_147)
        {
            this.workingHours_147 = workingHours_147;
        }

        // Phương thức get số giờ làm việc
        public int GetWorkingHours_147()
        {
            return this.workingHours_147;
        }

        // Ghi đè phương thức tính lương: số giờ làm * lương mỗi giờ
        public override int CalculateSalary_147()
        {
            return workingHours_147 * paymentPerHour_147;
        }
    }

    // Class con FullTimeEmployee_147 kế thừa từ Employee_147 (Nhân viên toàn thời gian)
    public class FullTimeEmployee_147 : Employee_147
    {
        // Constructor khởi tạo giá trị
        public FullTimeEmployee_147(string name_147, int paymentPerHour_147)
            : base(name_147, paymentPerHour_147) { }

        // Ghi đè phương thức tính lương: Nhân viên full-time luôn làm 8 giờ/ngày
        public override int CalculateSalary_147()
        {
            return 8 * paymentPerHour_147;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//Cho phép xuất tiếng Việt

            //List lưu danh sách nhân viên
            List<PartTimeEmployee_147> partTimeEmployees_147 = new List<PartTimeEmployee_147>();
            List<FullTimeEmployee_147> fullTimeEmployees_147 = new List<FullTimeEmployee_147>();

            int luaChon = -1;
            while (luaChon != 0)
            {
                Console.WriteLine("\n===========>>>    MENU    <<<==========");
                Console.WriteLine(" 1. Thêm nhân viên PartTime");
                Console.WriteLine(" 2. Thêm nhân viên FullTime");
                Console.WriteLine(" 3. Xem danh sách nhân viên PartTime");
                Console.WriteLine(" 4. Xem danh sách nhân viên FullTime");
                Console.WriteLine(" 5. Xem tất cả nhân viên");
                Console.WriteLine(" 0. Thoát");
                Console.WriteLine("=======================================");
                Console.Write("Nhập lựa chọn của bạn: ");
                while(!int.TryParse(Console.ReadLine(), out luaChon)  || luaChon < 0 || luaChon > 5)
                {
                    Console.Write("Lựa chọn không hợp lệ! Nhập lại (0-5): ");
                };

                switch (luaChon)
                {
                    case 0:
                        Console.WriteLine("\nKết thúc chương trình!");
                        break;
                    case 1:
                        //Thêm nhân viên PartTime
                        Console.Write("\nNhập tên nhân viên: ");
                        string namePT_147 = Console.ReadLine();

                        Console.Write("Nhập lương mỗi giờ: ");
                        int paymentPerHourPT_147;
                        while (!int.TryParse(Console.ReadLine(), out paymentPerHourPT_147) || paymentPerHourPT_147 <= 0)
                        {
                            Console.Write("Lương phải lớn hơn 0! Nhập lại: ");
                        }

                        Console.Write("Nhập số giờ làm việc mỗi ngày: ");
                        int workingHoursPT_147;
                        while (!int.TryParse(Console.ReadLine(), out workingHoursPT_147) || workingHoursPT_147 <= 0)
                        {
                            Console.Write("Giờ làm phải lớn hơn 0! Nhập lại: ");
                        }

                        PartTimeEmployee_147 newPartTimeEmployee_147 = new PartTimeEmployee_147(namePT_147, paymentPerHourPT_147, workingHoursPT_147);  
                        partTimeEmployees_147.Add(newPartTimeEmployee_147);
                        Console.WriteLine("Thêm nhân viên Part-Time thành công!\n");
                        break;
                    case 2:
                        //Thêm nhân viên FullTime
                        Console.Write("\nNhập tên nhân viên: ");
                        string nameFT_147 = Console.ReadLine();

                        Console.Write("Nhập lương mỗi giờ: ");
                        int paymentPerHourFT_147;
                        while (!int.TryParse(Console.ReadLine(), out paymentPerHourFT_147) || paymentPerHourFT_147 <= 0)
                        {
                            Console.Write("Lương phải lớn hơn 0! Nhập lại: ");
                        }

                        FullTimeEmployee_147 newFullTimeEmployee_147 = new FullTimeEmployee_147(nameFT_147, paymentPerHourFT_147);
                        fullTimeEmployees_147.Add(newFullTimeEmployee_147);
                        Console.WriteLine("Thêm nhân viên Full-Time thành công!\n");
                        break;
                    case 3:
                        //Xem danh sách nhân viên PartTime
                        if (partTimeEmployees_147.Count == 0)
                        {
                            Console.WriteLine("\nKhông có nhân viên Part-Time nào!");
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách nhân viên Part-Time:");
                            foreach (var emp in partTimeEmployees_147)
                            {
                                Console.WriteLine("+ Tên nhân viên: {0}\n  Tiền lương một ngày: {1} VND",emp.GetName_147(), emp.CalculateSalary_147());
                            }
                        }
                        break;
                    case 4:
                        //Xem danh sách nhân viên FullTime
                        if (fullTimeEmployees_147.Count == 0)
                        {
                            Console.WriteLine("\nKhông có nhân viên Full-Time nào!");
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách nhân viên Full-Time:");
                            foreach (var emp in fullTimeEmployees_147)
                            {
                                Console.WriteLine("+ Tên nhân viên: {0}\n  Tiền lương một ngày: {1} VND", emp.GetName_147(), emp.CalculateSalary_147());
                            }
                        }
                        break;
                    case 5:
                        //Danh sách tất cả nhân viên

                        if (partTimeEmployees_147.Count == 0 && fullTimeEmployees_147.Count == 0)
                        {
                            Console.WriteLine("\nDanh sách trống!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách tất cả nhân viên:");
                        }

                        if (partTimeEmployees_147.Count == 0)
                        {
                            Console.WriteLine("- Không có nhân viên Part-Time nào!");
                        }
                        else
                        {
                            Console.WriteLine("- Danh sách nhân viên Part-Time:");
                            foreach (var emp in partTimeEmployees_147)
                            {
                                Console.WriteLine("   + Tên nhân viên: {0}\n     Tiền lương một ngày: {1} VND", emp.GetName_147(), emp.CalculateSalary_147());
                            }
                        }
                        if (fullTimeEmployees_147.Count == 0)
                        {
                            Console.WriteLine("- Không có nhân viên Full-Time nào!");
                        }
                        else
                        {
                            Console.WriteLine("- Danh sách nhân viên Full-Time:");
                            foreach (var emp in fullTimeEmployees_147)
                            {
                                Console.WriteLine("   + Tên nhân viên: {0}\n     Tiền lương một ngày: {1} VND", emp.GetName_147(), emp.CalculateSalary_147());
                            }
                        }
                        break;
                }              
            }
            Console.ReadKey();
        }
    }
}
