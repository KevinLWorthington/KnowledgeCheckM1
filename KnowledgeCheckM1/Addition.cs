using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Addition : Calculator
    {
        public Addition()
        {
            var calculator = new Calculator();
            Console.WriteLine("Enter 2 integers to add:");
            var addNumber1 = Console.ReadLine();
            var addNumber2 = Console.ReadLine();

            if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
            {
                Console.WriteLine($"{addNumOne} + {addNumTwo} = {calculator.Add(addNumOne, addNumTwo)}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
