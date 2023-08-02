using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            SimpleMath NumberValue = new SimpleMath();

            // Getting 2 numbers from the user
            Console.WriteLine("Please enter a number:");
            int userValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number:");
            int userValue2 = Convert.ToInt32(Console.ReadLine());

            // Calling the method, passing in the two numbers
            NumberValue.Addition(userValue1, userValue2);
            Console.ReadLine();

            // Calling the method (specifiying the parameters by name)
            NumberValue.Addition(x: userValue2, y: userValue1);
            Console.ReadLine();

        }
    }
}
