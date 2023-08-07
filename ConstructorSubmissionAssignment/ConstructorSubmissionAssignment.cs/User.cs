using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment.cs
{
    public class User
    {
        // Chaining constructors together
        public User(string firstName) : this(firstName, "Online")
        {

        }
        public User(string firstName, string status)
        {
            Name = firstName;
            Status = status;
        }

        public string Name { get; set; }
        public string Status { get; set; }
    }
}
