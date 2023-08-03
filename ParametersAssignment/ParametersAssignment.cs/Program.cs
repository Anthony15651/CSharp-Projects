using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the Employee object with "string"
            Employee<string> employeeString = new Employee<string>();
            List<string> stringList = new List<string> { "This", "is", "a", "list", "of", "strings." };

            // Assinging a list of strings
            employeeString.things = stringList;

            // Instantiating the Employee object with "int"
            Employee<int> employeeInt = new Employee<int>();
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Assigning a list of integers
            employeeInt.things = intList;

            // Loop to print out all "Things" to console
            foreach (object item in employeeInt.things)
            {
                Console.WriteLine(item);
            }
            foreach (object item in employeeString.things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
