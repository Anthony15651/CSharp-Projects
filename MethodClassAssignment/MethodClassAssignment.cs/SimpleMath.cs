using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment.cs
{
    public class SimpleMath
    {
        public SimpleMath()
        {

        }
        public int NumberValue { get; set; }

        // Creating a void method that take two integers as parameters
        public void Addition(int x, int y)
        {
            // Doing math on the first integer
            int result = x * 5;
            //Console.WriteLine(result);

            // Displaying the second integer to the screen
            Console.WriteLine(y);
            return;
        }

    }
}
