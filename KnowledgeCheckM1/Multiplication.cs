using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Multiplication
    {
        public Multiplication()
        {
            var calculator = new Calculator();
            UserInput userInput = new();

            if (int.TryParse(userInput.NumOne, out int mulNumOne) && int.TryParse(userInput.NumTwo, out int mulNumTwo))
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
