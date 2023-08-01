using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
{
    public class SimpleMath
    {
        public SimpleMath()
        {

        }
        public int NumberValue { get; set; }

        // Addition method
        public int Addition(int userInput)
        {
            return (userInput + 10);
        }

        // Subtraction method
        public int Subtraction(int userInput)
        {
            return (userInput - 10);
        }

        // Multiplication method
        public int Multiply(int userInput)
        {
            return (userInput * 10);
        }

    }
}
