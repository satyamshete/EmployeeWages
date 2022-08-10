using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpDailyWage
    {
        public void DailyWage()
        {
            Console.WriteLine("UC2-Calculate Daily Employee Wage");
            Random rand = new Random();
            int empCheck = rand.Next(1, 3); // it will give values from 1 till 3 but not 3 so possible output is 1,2
            int isFullTime = 1;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            if (empCheck == isFullTime)
            {
                empHrs = 8;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present and its salary is: " + dailyWage);
            }
            else
            {
                empHrs = 0;
                dailyWage = wagePerHour * empHrs;
                Console.WriteLine("Employee is absent and its salary is: " + dailyWage);
            }
        }
        }
}
