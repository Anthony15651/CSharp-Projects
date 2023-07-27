using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    class Program
    {
        static void Main()
        {
            // Prints the first two lines of the Daily Report
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // Gets user's name and course name as a string
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string myCourse = Console.ReadLine();

            // Gets user's page number as a string, then converts to "short" (could also be "int")
            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            Convert.ToUInt16(pageNum);

            // Gets user's need for help and converts to "bool"
            Console.WriteLine("Do you need help with anything? (Please answer 'True' or 'False')");
            string needHelp = Console.ReadLine();
            Convert.ToBoolean(needHelp);

            // Gets user's experience and feedback as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string myFeedback = Console.ReadLine();

            // Gets user's hours studied, then converts to "int"
            Console.WriteLine("How many hours did you study today?");
            string myHours = Console.ReadLine();
            Convert.ToInt32(myHours);

            // Printing final statement and added Console.ReadLine() to allow user to read the line before the terminal closes
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            
        }
    }
}
