using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the current date and time to the console
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);

            // Getting a number from the user
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Printing to console the exact time it will be in "userInput" hours
            TimeSpan timeDifference = new TimeSpan(userInput, 0, 0);
            DateTime futureTime = rightNow.Add(timeDifference);
            Console.WriteLine("The time in {0} hours will be: {1}", userInput, futureTime);

            Console.ReadLine();
        }
    }
}
