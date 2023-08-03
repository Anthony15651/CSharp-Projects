using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{

    // Creating the Employee class, which inherits from the "Person" class
    // Added "IQuittable" for the employee to inherit
    public class Employee : Person, IQuittable
    {

        // Implementing the "SayName()" method in the employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        // Implementing the "Quit()" method
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
