using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ComputeWage
    {
        internal int totalWage;
        const int isFullTime = 1;
        const int isPartTime = 2;
        internal string CompanyName;
        internal List<int> DailyWage = new List<int>(); 

        public ComputeWage(string companyName, int wagePerHour, int NoOfWorkingDays, int totalWorkingHrs)
        {
            this.CompanyName = companyName;
            int empHrs;
            int dailyWage;
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
                DailyWage.Add(dailyWage);
                totalWage = totalWage + dailyWage;
                totalWorkingDays++;
            }


        }

        internal void DisplaySalary()
        {
            Console.WriteLine("Total Employee wage for company {0}  is {1}", CompanyName, totalWage);
        }

    }
}
