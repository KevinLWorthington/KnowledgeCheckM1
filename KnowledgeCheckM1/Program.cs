using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Security.Cryptography.X509Certificates;

namespace KnowledgeCheckM1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the worst calculator you've ever used!\n");
            Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division\n");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    _ = new Addition();
                    break;

                case "2":
                    _ = new Subtraction();
                    break;

                case "3":
                    _ = new Multiplication();
                    break;

                case "4":
                    _ = new Division();
                    break;

                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            if (input?.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
