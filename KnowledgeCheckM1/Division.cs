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
            UserInput userInput = new UserInput();

            if (int.TryParse(userInput.NumOne, out int divNumOne) && int.TryParse(userInput.NumTwo, out int divNumTwo))
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
