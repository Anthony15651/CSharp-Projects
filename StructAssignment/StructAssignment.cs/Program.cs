using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the object and assigning an amount to it
            Number number = new Number() { Amount = 5 };

            // Printint the amount to the console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
