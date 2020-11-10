using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Step255
{
   public class Employees<T>

    {

       
        public List<string> Things { get; set; }
        public string things { get; set; }
        

        public string Add(string things)
        {
            return things;
        }

        public void PrintListToConsole()
        {
          foreach(string things in Things)
                {
                Console.WriteLine(things);
               
            }
           
        }
    }
}
