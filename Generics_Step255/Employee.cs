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
   public class Employee<T>

    { 
        int i;
       
        public List<T> Things { get; set; }
      
    
        public string Add(string things)
        {
            return things;
        }

        public void PrintListToConsole()
        {
            for (int i = 0; i < Things.Count; i++)
            { 
                Console.WriteLine(Things[i]);
               
            }
           
        }
    }
}
