using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpPresentAbsent
    {
        public void EmployeepresentAbsent()
        {
            Console.WriteLine("UC1-Employee present or absent");
            Random rand = new Random();
            int empCheck = rand.Next(1, 3); // it will give values from 1 till 3 but not 3 so possible output is 1,2
            int isFullTime = 1;
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
