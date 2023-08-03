using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment.cs
{
    // Creating the employee class
    public class Employee<T>
    {
        // Adding the "things" property as a generic list
        public List<T> things { set; get; }
    }
}
