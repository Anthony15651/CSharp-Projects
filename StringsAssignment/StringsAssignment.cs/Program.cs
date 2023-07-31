using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment.cs
{
    class Program
    {
        static void Main()
        {
            // Concatenates three strings
            string one = "This is ";
            string two = "three strings ";
            string three = "concatinated.";

            Console.WriteLine(one + two + three);

            // Converts string to upper
            string name = "anthony";
            Console.WriteLine("Here is the string \"anthony\"");
            string nameUpper = name.ToUpper();
            Console.WriteLine("Here is that string with \"ToUpper\" applied:\n" + nameUpper);

            // Creates a Stringbuilder
            StringBuilder mySB = new StringBuilder();
            mySB.Append("This will be a paragraph of appended sentences. ");
            mySB.Append("Usually, a paragraph is five sentences. ");
            mySB.Append("I've ran out of sentence ideas. ");
            mySB.Append("This paragraph will only be four sentences instead.");
            Console.WriteLine(mySB);


            Console.ReadLine();

        }
    }
}
