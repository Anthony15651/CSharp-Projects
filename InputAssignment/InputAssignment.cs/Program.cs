using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking user for input
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            // Logging user input into text file
            File.WriteAllText(@"C:\Users\antho\OneDrive\Desktop\test.txt", userInput);

            // Retrieving user input and writing it to the console
            string textResult = File.ReadAllText(@"C:\Users\antho\OneDrive\Desktop\test.txt");
            Console.WriteLine("The number you entered was: " + textResult);

            Console.ReadLine();
        }
    }
}
