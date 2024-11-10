using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Division : Calculator
    {
        public Division()
        {
            var calculator = new Calculator();
            Console.WriteLine("Enter 2 integers to divide:");
            var divNumber1 = Console.ReadLine();
            var divNumber2 = Console.ReadLine();

            if (int.TryParse(divNumber1, out int divNumOne) && int.TryParse(divNumber2, out int divNumTwo))
            {
                try
                {
                    Console.WriteLine($"{divNumOne} / {divNumTwo} = {calculator.Divide(divNumOne, divNumTwo)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
