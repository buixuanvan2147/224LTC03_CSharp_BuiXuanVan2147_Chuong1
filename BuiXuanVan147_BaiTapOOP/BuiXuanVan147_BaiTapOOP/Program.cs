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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//Cho phép xuất tiếng Việt


        }
    }
}
