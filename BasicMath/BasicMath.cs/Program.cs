using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath.cs
{
    class Program
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;

            // Addition
            int sum = num1 + num2;
            Console.WriteLine(sum);

            // Subtraction
            int difference = num1 - num2;
            Console.WriteLine(difference);

            // Multiplication
            int product = num1 * num2;
            Console.WriteLine(product);

            // Division
            int dividend = num1 / num2;
            Console.WriteLine(dividend);

            // String Concatination
            string firstName = "Anthony";
            string lastName = "Garcia";
            Console.WriteLine(firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}
