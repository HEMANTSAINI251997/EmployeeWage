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
            int is_present = 1;
            int full_day_hr = 8;
            int wage_per_hr = 20;
            int emp_hr = 0;
            Random random = new Random();
            int check = random.Next(0, 2);

            if (check == is_present)
            {
                Console.WriteLine("Employee is Present");
                emp_hr = full_day_hr;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emp_hr = 0;
            }
            int totalwage = emp_hr * wage_per_hr;
            Console.WriteLine("Total wage of Employee is = " + totalwage);
        }
    }
}
