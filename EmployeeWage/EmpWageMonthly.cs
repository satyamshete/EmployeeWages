using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageMonthly
    {
        public void MonthlyWage()
        {
            Console.WriteLine("UC5-Calculating Wages for a Month");
            Random rand = new Random();
            // it will give values from 0 till 3 but not 3 so possible output is 1,2
            const int isFullTime = 1;
            const int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int workingDays = 20;
            int i = 0;
            while (i < workingDays)
            {
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        dailyWage = wagePerHour * empHrs;

                        // Console.WriteLine("Employee is present for full time and its salary is: " + dailyWage);
                        break;
                    case isPartTime:
                        empHrs = 4;
                        dailyWage = wagePerHour * empHrs;

                        //  Console.WriteLine("Employee is present for Part time and its salary is: " + dailyWage);
                        break;
                    default:
                        empHrs = 0;
                        dailyWage = wagePerHour * empHrs;
                        //  Console.WriteLine("Employee is absent and its salary is: " + dailyWage);
                        break;

                }
                totalWage = totalWage + dailyWage;
                i++;
            }
            Console.WriteLine("Total Wage for Month is: " + totalWage);
        }
    }
}
