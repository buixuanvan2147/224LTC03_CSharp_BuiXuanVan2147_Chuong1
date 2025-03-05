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


        }
    }
}
