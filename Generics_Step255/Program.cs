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
            Employees<string> employees = new Employees<string>();
            employees.Things = new List<string>();
            employees.Things.Add("barbeque");
            employees.Things.Add("napkins");
            employees.Things.Add("plates");
            employees.Things.Add("wipes");
            
            employees.PrintListToConsole();
            Console.ReadLine();


        }
    }
}
