using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment.cs
{

    // Declaring a static class
    static class StaticClass
    {
        static StaticClass()
        {

        }
        static int Number { get; set; }

        public static int MultiplyByFive(int x)
        {
            return (x * 5);
        }
    }
}
