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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//Cho phép xuất tiếng Việt


        }
    }
}
