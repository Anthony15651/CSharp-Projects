using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumAssignment.cs
{
    class Program
    {
        static void Main()
        {
            bool tryAgain = true;

            // Prompting user for current day of the week
            Console.WriteLine("Please enter the current day of the week:");


            // Try / Catch block to make sure input is valid
            while (tryAgain)
            {
                try
                {
                    DayOfWeek userInput1 = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
                    Console.WriteLine("That day of the week checks out! Today is {0}.\nThanks!", userInput1);
                    tryAgain = false;
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week (Capitalized).");
                }
                finally
                {
                    
                }
            }
            Console.ReadLine();
            
        }
    }
}
