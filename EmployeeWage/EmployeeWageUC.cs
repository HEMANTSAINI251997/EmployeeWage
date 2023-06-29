using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC
    {
        const int is_present = 1;
        const int is_parttime = 2;
        public static void EmployeeWageFun(string company, int wage_per_hr, int workingdays, int workinghours)
        {
            int half_day = 4;
            int full_day_hr = 8;
            int totalemphr = 0;
            int totaldays = 0;
            int total_month_wage = 0;
            int emp_hr = 0;
            int totalworkinghr = 0;
            Random random = new Random();
            //Console.WriteLine("enter the emp hours");
            //int totalhrs = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the total days");
            //int days = Convert.ToInt32(Console.ReadLine());

            while (totalemphr <= workinghours && totaldays <= workingdays)
            {
                int check = random.Next(0, 3);
                totaldays++;
                switch (check)
                {
                    case is_present:
                        emp_hr = full_day_hr;
                        break;
                    case is_parttime:
                        emp_hr = half_day;
                        break;
                    default:
                        emp_hr = 0;
                        break;
                }
                totalworkinghr += emp_hr;
                totalemphr += emp_hr;


            }
            total_month_wage = totalworkinghr * wage_per_hr;

            Console.WriteLine("Total Wage of Employee at " + company + " for the month = " + total_month_wage);
        }
    }
}


