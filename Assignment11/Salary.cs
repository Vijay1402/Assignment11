using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{

    public class Salary
    {
        public double wHour, wDays;
        public int projectHandles, extras;
        public void inputDetails(int x)
        {
            Console.WriteLine("Enter the no of working hours");
            wHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of working days");
            wDays = double.Parse(Console.ReadLine());
            if (x > 1)
            {
                Console.WriteLine("Enter the no of project handles");
                projectHandles = int.Parse(Console.ReadLine());
            }
            if (x > 2)
            {
                Console.WriteLine("Enter the no of extras");
                extras = int.Parse(Console.ReadLine());
            }
        }
        public double calcSalary(double wHour, double wDays, int projectHandles = 1, int extras = 0)
        {
            double salary = wHour * wDays * 100 + projectHandles * 3000 + extras * 2000;
            return salary;
        }
    }
}
