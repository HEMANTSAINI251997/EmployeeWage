using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "WELCOME TO EMPLOYEE WAGE COMPUTATION" );
            EmployeeWageUC employeeWageUC = new EmployeeWageUC();
            employeeWageUC.EmployeeWageFun();

        }
    }
}
