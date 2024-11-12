using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class UserInput
    {
        public string? NumOne { get; set; }
        public string? NumTwo { get; set; }

        public UserInput()
        {
            
            Console.WriteLine("Enter the first number");
             NumOne = Console.ReadLine();
            Console.WriteLine("Enter the second number");
             NumTwo = Console.ReadLine();
            
        }
            
    }
}
