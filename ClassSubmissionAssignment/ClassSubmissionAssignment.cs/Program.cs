using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            SimpleMath NumberValue = new SimpleMath();
            int timesMultiplied = 0;

            // Gets a number from the user
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Calls method on the user's number
            NumberValue.Division(userInput);

            // Calling method with output parameters
            int times = 4; // Set how many times you'd like your number to double
            int product = NumberValue.Multiplication(userInput, out timesMultiplied, times);
            Console.WriteLine("Your number doubled {0} times equals: {1}", timesMultiplied, product);

            // Gets a string from the user (for method overloading)
            Console.WriteLine("Please enter a string:");
            string userString = Console.ReadLine();
            string userResult = NumberValue.Multiplication(userString);
            Console.WriteLine("Your string capitalized is: " + userResult);

            // Calling the static class
            int exampleInt = 5;
            Console.WriteLine(StaticClass.MultiplyByFive(exampleInt));

            Console.ReadLine();
        }
    }
}
