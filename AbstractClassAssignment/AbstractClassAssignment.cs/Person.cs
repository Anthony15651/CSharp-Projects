using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{

    // Creating an abstract class called "Person"
    public abstract class Person
    {

        // Giving properties "firstName" and "lastName:
        public string firstName { get; set; }
        public string lastName { get; set; }


        // Giving it the method "SayName()"
        public abstract void SayName();

    }
}
