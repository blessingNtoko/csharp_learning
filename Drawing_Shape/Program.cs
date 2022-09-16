using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the operator: ");
            string operation = Console.ReadLine();

            Console.Write("Please enter the first value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The answer is {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"The answer is {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"The answer is {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"The answer is {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("You have entered an invalid operator");
                    break;
            }

        }

        static int FindMax(int[] numArray)
        {
            int result = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > result)
                {
                    result = numArray[i];
                }
            }

            return result;

        }
    }
}