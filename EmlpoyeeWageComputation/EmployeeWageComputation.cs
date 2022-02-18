using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlpoyeeWageComputation
{
    internal class EmployeeWageComputation
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int EMP_RATE_PER_HOUR = 20;
        private const int NUM_OF_WORKING_DAY = 20;
        private const int MAX_HOURS_IN_MONTH = 100;

        private int empHrs = 0;
        private int empWage = 0;
        private int totalempWage = 0;
        private int totalEmpHrs = 0;
        private int totalworkingdays = 0;

        Random random = new Random();

        public void GetAttendance()

        { int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is absent");
            else
                Console.WriteLine("Employee is present");
        }

        public void EmpWage()

        {

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + empWage);
            Console.ReadKey();



        }

        public void PartTime()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
        public void CalculateWageSwitch()
        {
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalempWage += empWage;   //int a=6; a+=10;a=a+10
            Console.WriteLine("Emp Wage: " + empWage);
            Console.WriteLine("Total Emp Wage: " + totalempWage);
        }
        public void CalculateWagesFor20DaysInMonth()
        {
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalempWage += empWage;   //int a=6; a+=10;a=a+10
                Console.WriteLine("Emp Wage: " + empWage);
            }
                Console.WriteLine("Total Emp Wage: " + totalempWage);
                Console.ReadKey();
        }   
    }

}   
    
