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
            int Is_Present = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Is_Present)
            {
                Console.WriteLine("Employee is Present");
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
