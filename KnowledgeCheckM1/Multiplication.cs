using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Multiplication : Calculator
    {
        public Multiplication()
        {
            var calculator = new Calculator();
            Console.WriteLine("Enter 2 integers to multiply:");
            var mulNumber1 = Console.ReadLine();
            var mulNumber2 = Console.ReadLine();

            if (int.TryParse(mulNumber1, out int mulNumOne) && int.TryParse(mulNumber2, out int mulNumTwo))
            {
                Console.WriteLine($"{mulNumOne} * {mulNumTwo} = {calculator.Multiply(mulNumOne, mulNumTwo)}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
