using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ComputeEmpWage
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        const int wagePerHour = 20;
        const int totalWorkingHrs = 100;
        const int workinDays = 20;
        public static void ComputeWage()
        {
            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;
            Random rand = new Random();


            while (totalWorkingDays < workinDays && totalNoOfHrs <= totalWorkingHrs)
            {
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        dailyWage = wagePerHour * empHrs;
                        totalNoOfHrs = totalNoOfHrs + empHrs;


                        break;
                    case isPartTime:
                        empHrs = 4;
                        dailyWage = wagePerHour * empHrs;
                        totalNoOfHrs = totalNoOfHrs + empHrs;

                        break;
                    default:
                        empHrs = 0;
                        dailyWage = wagePerHour * empHrs;
                        totalNoOfHrs = totalNoOfHrs + empHrs;
                        break;

                }
                totalWage = totalWage + dailyWage;
                totalWorkingDays++;
            }
            Console.WriteLine("Total Wage for Month is: " + totalWage);
            Console.WriteLine("Total No of hours are {0} and working days are {1}", totalNoOfHrs, totalWorkingDays);
        }
    }
}

