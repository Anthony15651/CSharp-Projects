using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;

            // Asking user for their age
            Console.WriteLine("Please enter your age.");

            // Try / Catch block for user input
            try
            {
                // Displaying the year the user was born
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput <= 0) throw new InvalidOperationException();
                DateTime birthYear = rightNow.AddYears(-userInput);
                DateTime birthYear2 = rightNow.AddYears(-(userInput + 1));
                Console.WriteLine("If you've already had your birthday this year, your birth year was {0}. Otherwise, your birth year was {1}.", birthYear.Year, birthYear2.Year);
                Console.ReadLine();
                return;
            }
            // Catch for numbers less than 1
            catch (InvalidOperationException)
            {
                Console.WriteLine("Your age must be greater than 0.");
                Console.ReadLine();
            }
            // Catch for everything else
            catch (Exception)
            {
                Console.WriteLine("Your input must be a number!");
                Console.ReadLine();
                return;
            }
        }
    }
}
