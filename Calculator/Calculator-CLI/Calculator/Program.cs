using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operation;
            char repeatRequest;
            bool repeat= false;
            
            Console.WriteLine("Welcome to the Calculator!");

            do
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("a: Addition");
                Console.WriteLine("s: Substraction");
                Console.WriteLine("m: Multiplication");

                Console.Write("Select the type of calculation: ");
                operation = Char.ToLower(Convert.ToChar(Console.ReadLine()));

                switch (operation)
                {
                    case 'a':
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;
                    case 's':
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;
                    case 'm':
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Do another calculation: (Y/N)");
                repeatRequest = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (repeatRequest == 'y')
                {
                    repeat = true;
                } else {
                    repeat = false;
                }


            } while (repeat);
        }
    }
}
