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
        public static void EmployeeWageFun()
        { 
            int half_day = 4;
            int full_day_hr = 8;
            int wage_per_hr = 20;
            int emp_hr = 0;
            int totalemphr = 0;
            int totaldays = 0;
            int totalwage = 0;
            Random random = new Random();

            while (totalemphr <= 100 && totaldays <= 20)
            {
                int check = random.Next(0, 3);
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

                totalemphr += emp_hr;
                totaldays++;
                int dailyWage = emp_hr * wage_per_hr;
                totalwage += dailyWage;
            }

            Console.WriteLine("Total Employee Hours for 20 Days = " + totalemphr);
            Console.WriteLine("Total Wage of Employee for 20 Days = " + totalwage);
        }
    }
}


