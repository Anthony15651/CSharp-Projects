using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a constant variable
            const string introLine = "Please enter your name.";

            // Creating a variable using the keyword "var"
            Console.WriteLine(introLine);
            var userName = Console.ReadLine();

            User user = new User(userName);
            Console.WriteLine("Hello {0}, your current status is: {1}", user.Name, user.Status);

            Console.ReadLine();
        }
    }
}
