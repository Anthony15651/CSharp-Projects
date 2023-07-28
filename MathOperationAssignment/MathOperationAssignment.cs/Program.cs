using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment.cs
{
    class Program
    {
        static void Main()
        {
            // Get user input, multiply by 50, then print result
            Console.WriteLine("Please enter your favorite positive, whole number:");
            string userMultiplyString = Console.ReadLine();
            int userNumberMultiply = Convert.ToInt32(userMultiplyString);
            int userProduct = userNumberMultiply * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + userProduct);

            // Get user input, add to it by 25, then print result
            Console.WriteLine("Please enter another whole number:");
            string userAdditionString = Console.ReadLine();
            int userNumberAdd = Convert.ToInt32(userAdditionString);
            int userSum = userNumberAdd + 25;
            Console.WriteLine("Your number plus 25 is: " + userSum);

            // Get user input, divide it by 12.5, then print result
            Console.WriteLine("Please enter another number:");
            string userDivisionString = Console.ReadLine();
            double userNumberDivide = Convert.ToDouble(userDivisionString);
            double userQuotient = userNumberDivide / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + userQuotient);

            // Get user input, checks if it is greater than 50, then print result
            Console.WriteLine("Please enter another whole number:");
            string userBoolString = Console.ReadLine();
            int userNumberBool = Convert.ToInt32(userBoolString);
            bool numberCheck = userNumberBool > 50;
            Console.WriteLine("Your number is greater than 50: " + numberCheck);

            // Get user input, divide input by 7, then print remainder
            Console.WriteLine("Please enter another whole number:");
            string userRemainderString = Console.ReadLine();
            int userNumberRemainder = Convert.ToInt32(userRemainderString);
            int userRemainder = userNumberRemainder % 7;
            Console.WriteLine("After dividing your number by 7, the remainder is: " + userRemainder);


            Console.WriteLine("Thanks for all the numbers!");
            Console.ReadLine();
        }
    }
}
