using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment.cs
{
    public class SimpleMath
    {
        public SimpleMath()
        {

        }
        public int NumberValue { get; set; }

        // Void method that outputs an integer
        public void Division(int x)
        {
            // Dividing the data passed by 2
            int result = x / 2;

            // Displaying the output ont the screen
            Console.WriteLine("Your number divided by two is: " + result);
        }

        // Method with output parameters
        public int Multiplication(int x, out int timesMultiplied, int times = 1)
        {
            timesMultiplied = 0;
            for (int i = 0; i < times; i++)
            {
                timesMultiplied++;
                x = x * 2;
            }
            return (x);
        }

        // Overloading a method
        public string Multiplication(string x)
        {
            return(x.ToUpper());
        }


    }
}
