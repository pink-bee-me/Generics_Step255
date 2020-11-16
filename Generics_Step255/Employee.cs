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
   public class Employee<TThings>

    { 
        public Employee(Tasks task)
        {
            Task = task;
            Id = Id;
        }
       
        public List<TThings> Things { get; set; }
        public Tasks { get; set; }
        public int Id { get; set; }
      
    
        public string Add()
        {
            return things;
        }

        public void PrintListToConsole()
        {
            for (int i = 0; i < employee1.Things.Count; i++)
            { 
                Console.WriteLine(Things[i]);
               
            }

            for (int j = 0; j > employee2.Things.Count; j++)
            { }
           
        }
    }
}
