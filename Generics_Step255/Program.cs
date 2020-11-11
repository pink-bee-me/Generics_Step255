using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Step255
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>();
            employee1.Things.Add("barbeque");
            employee1.Things.Add("napkins");
            employee1.Things.Add("plates");
            employee1.Things.Add("wipes");

            employee1.PrintListToConsole();
            Console.ReadLine();

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 3, 5, 7, 9, 11 };
            employee2.PrintListToConsole();
            Console.ReadLine();
        }
    }
}
