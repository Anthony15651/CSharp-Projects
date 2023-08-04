using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an empty list of employees
            List<Employee> employees = new List<Employee>();

            // Creating 10 employees and adding them to the list
            Employee employee1 = new Employee { ID = 1, FirstName = "Joe", LastName = "Smith" };
            employees.Add(employee1);
            Employee employee2 = new Employee { ID = 2, FirstName = "Bob", LastName = "Jackson" };
            employees.Add(employee2);
            Employee employee3 = new Employee { ID = 3, FirstName = "Bill", LastName = "Graham" };
            employees.Add(employee3);
            Employee employee4 = new Employee { ID = 4, FirstName = "Joe", LastName = "Wright" };
            employees.Add(employee4);
            Employee employee5 = new Employee { ID = 5, FirstName = "Sue", LastName = "Blue" };
            employees.Add(employee5);
            Employee employee6 = new Employee { ID = 6, FirstName = "Harry", LastName = "Berry" };
            employees.Add(employee6);
            Employee employee7 = new Employee { ID = 7, FirstName = "Anthony", LastName = "Garcia" };
            employees.Add(employee7);
            Employee employee8 = new Employee { ID = 8, FirstName = "Barney", LastName = "Rubble" };
            employees.Add(employee8);
            Employee employee9 = new Employee { ID = 9, FirstName = "Hazel", LastName = "Basil" };
            employees.Add(employee9);
            Employee employee10 = new Employee { ID = 10, FirstName = "Cella", LastName = "Rael" };
            employees.Add(employee10);

            // Using a foreach loop to put all employees named "Joe" into a new list
            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            // Performing the same action, this time with a lambda function
            List<Employee> employeesNamedJoe1 = new List<Employee>();
            employeesNamedJoe1 = employees.Where(x => x.FirstName == "Joe").ToList();

            // Using a lambda expression to create a new list of all Employees with ID > 5
            List<Employee> employeesOverFive = new List<Employee>();
            employeesOverFive = employees.Where(x => x.ID > 5).ToList();



            // Printing my lists to the console
            Console.WriteLine("Employees named Joe (list 1):");
            foreach (Employee employee in employeesNamedJoe)
            {
                Console.WriteLine("{0} {1}\nID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }

            Console.WriteLine("Employees named Joe (list 2):");
            foreach (Employee employee in employeesNamedJoe1)
            {
                Console.WriteLine("{0} {1}\nID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }

            Console.WriteLine("Employees with an ID greater than 5:");
            foreach (Employee employee in employeesOverFive)
            {
                Console.WriteLine("{0} {1}\nID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }

            Console.ReadLine();

        }
    }
}
