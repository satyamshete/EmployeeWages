using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageSwitchCase
    {
        public void SwitchCasePartTimeFullTime()
        {
            Console.WriteLine("UC4-Solving using Switch Case Statement");
            Random rand = new Random();
            int empCheck = rand.Next(0, 3); // it will give values from 0 till 3 but not 3 so possible output is 1,2
            int isFullTime = 1;
            int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    dailyWage = wagePerHour * empHrs;

                    Console.WriteLine("Employee is present for full time and its salary is: " + dailyWage);
                    break;
                case 2:
                    empHrs = 4;
                    dailyWage = wagePerHour * empHrs;

                    Console.WriteLine("Employee is present for Part time and its salary is: " + dailyWage);
                    break;
                default:
                    empHrs = 0;
                    dailyWage = wagePerHour * empHrs;
                    Console.WriteLine("Employee is absent and its salary is: " + dailyWage);
                    break;

            }
        }
    }
}
