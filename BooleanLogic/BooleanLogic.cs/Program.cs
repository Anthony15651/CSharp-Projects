using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false); // False
            Console.WriteLine(true && true); // True
            Console.WriteLine(false && false); // False

            Console.WriteLine(true || true); // True
            Console.WriteLine(true || false); // True
            Console.WriteLine(false || false); // False

            Console.WriteLine(true == true); // True
            Console.WriteLine(true == false); // False
            Console.WriteLine(false == false); // True

            Console.WriteLine(true != true); // False
            Console.WriteLine(true != false); // True
            Console.WriteLine(false != false); // False

            Console.WriteLine(true ^ true); // False
            Console.WriteLine(true ^ false); // True
            Console.WriteLine(false ^ false); // False


            Console.ReadLine();
        }
    }
}
