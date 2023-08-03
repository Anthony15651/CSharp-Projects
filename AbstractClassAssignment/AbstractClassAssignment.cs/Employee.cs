using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{

    // Creating the Employee class, which inherits from the "Person" class
    public class Employee : Person
    {

        // Implementing the "SayName()" method in the employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
