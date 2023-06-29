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
            
            // Calculate employee wages for Company A
            string companyA = "Company A";
            int wageperhourA = 10;
            int workingdaysA = 20;
            int workinghoursA = 100;
            EmployeeWageUC.EmployeeWageFun(companyA, wageperhourA, workingdaysA, workinghoursA);

            // Calculate employee wages for Company B
            string companyB = "Company B";
            int wageperhourB = 12;
            int workingdaysB = 22;
            int workinghoursB = 110;
            EmployeeWageUC.EmployeeWageFun(companyB, wageperhourB, workingdaysB, workinghoursB);

            // Calculate employee wages for Company C
            string companyC = "Company C";
            int wageperhourC = 8;
            int workingdaysC = 18;
            int workinghoursC = 90;
            EmployeeWageUC.EmployeeWageFun(companyC, wageperhourC, workingdaysC, workinghoursC);

        }
    }
}

//EmployeeWageUC employeeWageUC = new EmployeeWageUC();
//employeeWageUC.EmployeeWageFun();
//Console.WriteLine("How many companies data you want to enter  :");
//int num = Convert.ToInt32(Console.ReadLine());
//string name = "";
//int emphr = 0;
//int wage = 0;
//int hrmonth = 0;
//for (int i = 1; i <= num; i++)
//{
//    Console.WriteLine("Enter the company names");
//    name = Console.ReadLine();
//    Console.WriteLine("Enter the number of working of Employee in hours");
//    emphr = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the number of Employee wage");
//    wage = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the number of working hours per month");
//    hrmonth = Convert.ToInt32(Console.ReadLine());


//}
