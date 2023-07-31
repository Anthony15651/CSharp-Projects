using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Anthony";
            string quote = "The man said, \"Hello, Anthony\".\nHello on a new line.\n\tHello on a tab.";
            string filename = @"C:\Users\Anthony";

            bool trueOrfalse = name.Contains("y");
            trueOrfalse = name.EndsWith("n");

            int length = name.Length;

            Console.WriteLine(length);
            Console.Read();
        }
    }
}
