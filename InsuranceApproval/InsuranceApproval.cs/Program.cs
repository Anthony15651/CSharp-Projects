using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval.cs
{
    class Program
    {
        static void Main()
        {
            // Progarm intro line
            Console.WriteLine("Are you qualified for our car insurance? Let's find out!");

            // Getting information from user
            Console.WriteLine("What is your age?");
            string userAgeString = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeString);

            Console.WriteLine("Have you ever had a DUI? (True or False)");
            string userDUIString = Console.ReadLine();
            bool userDUI = Convert.ToBoolean(userDUIString);

            Console.WriteLine("How many speeding tickets do you have?");
            string userTicketsString = Console.ReadLine();
            int userTickets = Convert.ToInt32(userTicketsString);

            // Logic to determine if user qualifies
            bool userQualified = (userAge > 15) && (userDUI == false) && (userTickets <= 3);
            Console.WriteLine("Are you qualified for our car insurance?\n" + userQualified);
            Console.ReadLine();
        }
    }
}
