using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageUC
    {
        public void EmployeeWageFun()
        {
            const int is_present = 1;
            const int is_parttime = 2;
            int half_day = 4;
            int full_day_hr = 8;
            int wage_per_hr = 20;
            int emp_hr = 0;
            int part_time = 8;
            int totalemphr = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check)
            {
                case is_present:
                    Console.WriteLine("Employee is Present");
                    emp_hr = full_day_hr;
                    break;
                case is_parttime:
                    Console.WriteLine("Employee is on Part Time");
                    emp_hr = half_day;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    emp_hr = 0;
                    break;


            }
            int totalwage = emp_hr * wage_per_hr;
            Console.WriteLine("Total wage of Employee is = " + totalwage);



        }

    }
}
