namespace EmployeeWage
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
            //EmpWageSwitchCase empWageSwitchCase = new EmpWageSwitchCase();
            //empWageSwitchCase.SwitchCasePartTimeFullTime();

            /////UC5
            //EmpWageMonthly empWageMonthly = new EmpWageMonthly();
            //empWageMonthly.MonthlyWage();

            ///////////UC6
            //ConditionalEmpWage conditionalEmpWage = new ConditionalEmpWage();
            //conditionalEmpWage.MonthlyWage();

            ///////////UC7 Employee wage by class method
            //ComputeEmpWage.ComputeWage();

            //////////UC8 for multiple companies
            //ForMultipleCompanies.ComputeWage("NAASA", 200, 18, 100);
            //ForMultipleCompanies.ComputeWage("Googlle", 100, 20, 160);

            ///////UC9
            //ComputeWage Nasa = new ComputeWage("Nasa", 200, 18, 100);
            //Nasa.DisplaySalary();

            /////UC10
            AddNewCompany company = new AddNewCompany();
            for (int i = 0; i < 3; i++)
            {

                company.AddCompanyByArray();

                if (i == 2)
                {
                    company.DisplayByArray();
                }
            }

        }
    }
}