using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class FullTimePartTime
    {
        public void PartTimeFullTime()
        {
            Console.WriteLine("UC3-Add Part time Employee & Wage");
            Random rand = new Random();
            int empCheck = rand.Next(0, 3); // it will give values from 0 till 3 but not 3 so possible output is 1,2
            int isFullTime = 1;
            int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            if (empCheck == isFullTime)
            {
                empHrs = 8;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present for full time and its salary is: " + dailyWage);
            }
            else if (empCheck == isPartTime)
            {
                empHrs = 4;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present for Part time and its salary is: " + dailyWage);
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
