using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the "Employee" object with a first and last name
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Calling the superclass method on the employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
