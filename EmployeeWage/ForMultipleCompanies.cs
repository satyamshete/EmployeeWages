using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ForMultipleCompanies
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        public static void ComputeWage(string CompanyName, int wagePerHour, int NoOfWorkingDays, int totalWorkingHrs)
        {

            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;
            Random rand = new Random();


            while (totalWorkingDays < NoOfWorkingDays && totalNoOfHrs <= totalWorkingHrs)
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

            Console.WriteLine("Total Employee wage for company {0}  is {1}", CompanyName, totalWage);
        }
    }
}

    

