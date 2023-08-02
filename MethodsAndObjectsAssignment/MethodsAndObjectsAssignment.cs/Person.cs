using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment.cs
{
    public class Person
    {
        // Giving the "Person" class FirstName and LastName properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Creating the "SayName" method to retrieve the user's name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
