using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Subtraction
    {
        public Subtraction()
        {
            var calculator = new Calculator();
            UserInput userInput = new();

            if (int.TryParse(userInput.NumOne, out int subNumOne) && int.TryParse(userInput.NumTwo, out int subNumTwo))
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
