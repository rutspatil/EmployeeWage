using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlpoyeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" =========Welcome To Employee Computation===");
            EmployeeWageComputation emp = new EmployeeWageComputation();
            //emp.GetAttendance();
            //emp.EmpWage();
            //emp.PartTime();
            emp.CalculateWageSwitch();
        }
    }
}
