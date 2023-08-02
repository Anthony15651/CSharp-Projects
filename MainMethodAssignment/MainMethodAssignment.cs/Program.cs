using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath NumberValue = new SimpleMath();

            Console.WriteLine("Please enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus 10 equals: " + NumberValue.Addition(userInput));

            Console.WriteLine("Please enter a decimal: ");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your number minus 10 equals: " + NumberValue.Addition(userInput2));

            Console.WriteLine("Please enter an integer string: ");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("Your number plus 50 equals: " + NumberValue.Addition(userInput3));

            Console.ReadLine();
        }

    }
}
