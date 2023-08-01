using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath myNumber = new SimpleMath();
            Console.WriteLine("Please input a number, and I will perform some calculations with it:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Calling addition function
            int userSum = myNumber.Addition(userInput);
            Console.WriteLine("Your number with 10 added to it is: " + userSum);

            // Calling subtraction function
            int userDifference = myNumber.Subtraction(userInput);
            Console.WriteLine("Your number with 10 taken away from it is: " + userDifference);

            // Calling multiplication function
            int userProduct = myNumber.Multiply(userInput);
            Console.WriteLine("Your number with 10 multiplied to it is: " + userProduct);

            Console.ReadLine();
        }
    }
}

