using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice.cs
{
    class Program
    {
        static void Main()
        {
            // Get user input to evaluate
            Console.WriteLine("Please enter a whole number from 0 - 10.");
            string userNumberString = Console.ReadLine();
            int userNumber = Convert.ToInt32(userNumberString);

            // Using if / else if / else statements
            if (userNumber <= 4)
            {
                Console.WriteLine("Your number is less than 5!");
            }
            else if(userNumber == 5)
            {
                Console.WriteLine("Your number equals 5!");
            }
            else
            {
                Console.WriteLine("Your number is greater than 5!");
            }

            if (userNumber != 5)
            {
                Console.WriteLine("Your number does not equal 5!");
            }

            if (userNumber > 5)
            {
                Console.WriteLine("Your number is greater than 5!");
            }

            Console.ReadLine();
        }
    }
}
