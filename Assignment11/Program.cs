using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 0;
            Salary obj = new Salary();
            Console.WriteLine("CHoose one of the option to calculate salary:\n1.HR\n2.Admin\n3.Software Deveoloper");
            int x = int.Parse(Console.ReadLine());
            obj.inputDetails(x);
            if (x==1)
            {
                salary = obj.calcSalary(obj.wHour, obj.wDays);
            }
            else if (x==2) 
            {
                salary = obj.calcSalary(obj.wHour, obj.wDays, obj.projectHandles);
            }
            else if (x == 3)
            {
                salary = obj.calcSalary(obj.wHour, obj.wDays, obj.projectHandles, obj.extras);
            }
            Console.WriteLine("The calculate salary is: Rs."+salary);
            Console.ReadKey();
        }
    }
}
