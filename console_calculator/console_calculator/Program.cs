using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator");
            get_operator(Console.ReadLine().Trim(), nr1, nr2);
            Console.ReadLine();
        }
        static void get_operator(string operat, int nr1, int nr2)
        {
            switch (operat)
            {
                case "+":
                    Console.WriteLine((nr1 + nr2).ToString());
                    break;
                case "-":
                    Console.WriteLine((nr1 - nr2).ToString());
                    break;
                case "*":
                    Console.WriteLine((nr1 * nr2).ToString());
                    break;
                case "/":
                    Console.WriteLine((nr1 / nr2).ToString());
                    break;
                default:
                    Console.WriteLine("please enter a valid operator");
                    get_operator(Console.ReadLine().Trim(), nr1, nr2);
                    break;
            }
        }
    }
}
