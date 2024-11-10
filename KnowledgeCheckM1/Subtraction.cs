using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Subtraction : Calculator
    {
        public Subtraction()
        {
            var calculator = new Calculator();
            Console.WriteLine("Enter 2 integers to subtract:");
            var subNumber1 = Console.ReadLine();
            var subNumber2 = Console.ReadLine();

            if (int.TryParse(subNumber1, out int subNumOne) && int.TryParse(subNumber2, out int subNumTwo))
            {
                Console.WriteLine($"{subNumOne} - {subNumTwo} = {calculator.Subtract(subNumOne, subNumTwo)}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
