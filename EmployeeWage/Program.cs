﻿namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program !!!");

            ////UC1
            //EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
            //empPresentAbsent.EmployeepresentAbsent();
  
            //Console.WriteLine();


            ///UC2
            //EmpDailyWage empDailyWage = new EmpDailyWage();
            //empDailyWage.DailyWage();

            ////UC3
            //FullTimePartTime fullTimePartTime = new FullTimePartTime();
            //fullTimePartTime.PartTimeFullTime();

            /////UC4
            EmpWageSwitchCase empWageSwitchCase = new EmpWageSwitchCase();
            empWageSwitchCase.SwitchCasePartTimeFullTime();
        }
    }
}