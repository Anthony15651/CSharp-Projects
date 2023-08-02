using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2.cs
{
    public class SimpleMath
    {
        public SimpleMath()
        {

        }
        public int NumberValue { get; set; }

        // Method that takes in two integers, one of them being optional
        public int Addition(int x, int y = 10)
        {
            return (x + y);
        }

    }
}
