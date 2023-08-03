using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two Employee objects and assigning values
            Employee employee1 = new Employee() { Id = 1, FirstName = "Sample", LastName = "Employee-One" };
            Employee employee2 = new Employee() { Id = 1, FirstName = "Sample", LastName = "Employee-Two" };
            bool isEqual = employee1 == employee2;
            bool isNotEqual = employee1 != employee2;

            // Comparing if the employee IDs are equal
            Console.WriteLine("Employee 1 ID (#{0}) = Employee 2 ID (#{1}): {2}", employee1.Id, employee2.Id, isEqual);
            Console.WriteLine("Employee 1 ID (#{0}) != Employee 2 ID (#{1}): {2}", employee1.Id, employee2.Id, isNotEqual);

            Console.ReadLine();
        }
    }
}
