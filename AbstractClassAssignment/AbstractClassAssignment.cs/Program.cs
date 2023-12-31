﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the employee object
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // Calling the "SayName()" method on the employee object
            employee.SayName();

            // Using polymorphism to create an object of type "IQuittable"
            IQuittable quittableObject = new Employee();

            // Calling the "Quit()" method on the IQuittable object
            quittableObject.Quit();

            Console.ReadLine();

        }
    }
}
