using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison.cs
{
    class Program
    {
        static void Main()
        {
            // Intro line of program
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get hourly rate and hours worked from user 1
            Console.WriteLine("Person 1, please enter your hourly rate:");
            string user1RateString = Console.ReadLine();
            double user1Rate = Convert.ToDouble(user1RateString);
            Console.WriteLine("Now, please enter your hours worked per week:");
            string user1HoursString = Console.ReadLine();
            double user1Hours = Convert.ToDouble(user1HoursString);
            Console.WriteLine("Thank you, Person 1.");

            // Get hourly rate and hours worked from user 2
            Console.WriteLine("Person 2, please enter your hourly rate:");
            string user2RateString = Console.ReadLine();
            double user2Rate = Convert.ToDouble(user2RateString);
            Console.WriteLine("Now, please enter your hours worked per week:");
            string user2HoursString = Console.ReadLine();
            double user2Hours = Convert.ToDouble(user2HoursString);
            Console.WriteLine("Thank you, Person 2.");

            // Calculates annual salary for each user, then prints results
            double user1Salary = (user1Rate * user1Hours) * 52;
            double user2Salary = (user2Rate * user2Hours) * 52;
            Console.WriteLine("Annual salary of Person 1:\n" + user1Salary);
            Console.WriteLine("Annual salary of Person 2:\n" + user2Salary);

            // Bool to check if Person 1 makes more than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryCheck = user1Salary > user2Salary;
            Console.WriteLine(salaryCheck);


            Console.ReadLine();
        }
    }
}
