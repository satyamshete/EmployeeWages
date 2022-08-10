namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program !!!");

            ////UC1
            EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
            empPresentAbsent.EmployeepresentAbsent();
           
            Console.WriteLine();
        }
    }
}