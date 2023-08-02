using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            SimpleMath NumberValue = new SimpleMath();

            // Asks user for both numbers
            Console.WriteLine("Please enter a number:");
            int userValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number (optional) or just hit \"Enter\":");
            string userString = Console.ReadLine();

            // Checks for second variable
            if (userString == "")
            {
                // If only 1 variable was input, then the program returns that value plus 10
                Console.WriteLine("Your number plus 10 is: " + NumberValue.Addition(userValue1));
            }
            else
            {
                // If both variables are input, then the program returns the sum
                int userValue2 = Convert.ToInt32(userString);
                Console.WriteLine("The sum of your numbers is: " + NumberValue.Addition(userValue1, userValue2));
            }
            Console.ReadLine();
        }
    }
}
