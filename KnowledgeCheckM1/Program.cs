using KnowledgeCheckM1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Security.Cryptography.X509Certificates;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the worst calculator you've ever used!\n");
            Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division\n");

            var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Addition addition = new();
                        break;

                    case "2":
                        Subtraction subtraction = new();
                        break;

                    case "3":
                        Multiplication multiplication = new();
                        break;

                    case "4":
                        Division division = new();
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            
            if (input.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
