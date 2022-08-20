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
            // AddNewCompany company = new AddNewCompany();
            //for (int i = 0; i < 3; i++)
            //{

            //    company.AddCompanyByArray();

            //    if (i == 2)
            //    {
            //        company.DisplayByArray();
            //    }
            //}


            ////UC11
            //AddNewCompany company = new AddNewCompany();
            //for (int i = 0; i < 3; i++)
            //{

            //    company.AddCompanyByArray();

            //    if (i == 2)
            //    {
            //        company.DisplayByArray();
            //    }
            //}

            ////UC12 
            //AddNewCompany company = new AddNewCompany();
            //Console.WriteLine("Enter y to add company");
            //string input = Console.ReadLine();
            //while (input == "y")
            //{
            //    company.AddCompanyBylist();
            //    Console.WriteLine("Company Data Stored again enter y to add company");
            //    input = Console.ReadLine();

            //}
            //company.DisplayByList();

            /////UC13
            AddNewCompany company = new AddNewCompany();
            Console.WriteLine("Enter y to add company");
            string input = Console.ReadLine();
            while (input == "y")
            {
                company.AddCompanyBylist();
                Console.WriteLine("Company Data Stored again enter y to add company");
                input = Console.ReadLine();

            }
            company.DisplayByList();
            company.DisplayDailyByList();

        }
    }
}