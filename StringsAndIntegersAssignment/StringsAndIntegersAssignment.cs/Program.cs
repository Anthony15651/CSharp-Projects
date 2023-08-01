using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating list
            List<int> intList = new List<int> { 10, 12, 32, 26, 9, 33, 4, 117, 23 };
            Console.WriteLine("Please enter a number to divide each number in my list by.");
            {
                // Loop to try
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in intList)
                    {
                        int result = number / userInt;
                        Console.WriteLine(result);
                    }
                }
                // Catch if user divides by 0
                catch (DivideByZeroException)
                {
                    Console.WriteLine("I'm sorry, but you cannot divide by zero.");
                }
                // Catch if user enters a string
                catch (FormatException)
                {
                    Console.WriteLine("I'm sorry, but you must enter an integer.");
                }
                // Catch any other error and display the error message
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
                
            }
            Console.WriteLine("Emerged from block.");
            Console.ReadLine();
        }
    }
}
