using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheckM1
{
    public class Addition
    {
        public Addition()
        {
            var calculator = new Calculator();
            UserInput userInput = new();

          if (int.TryParse(userInput.NumOne, out int addNumOne) && int.TryParse(userInput.NumTwo, out int addNumTwo))
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
