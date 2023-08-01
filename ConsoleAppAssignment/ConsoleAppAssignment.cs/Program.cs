using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 1: ----------------------------------------");
            string[] stringArray = { "This", "is", "an", "array", "of", "strings." };
            Console.WriteLine("Please input some text.");
            string userString = Console.ReadLine();

            // Loop to iterate through array and add user's text to each string.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userString;
            }

            // Loop that prints off each string in the array.
            foreach (string i in stringArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            // Assignment 2:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 2: ----------------------------------------");
            bool infinite = true;

            // Infinite loop (commented out to keep from running):
            //while (infinite)
            //{
            //    Console.WriteLine("And they don't stop coming.");
            //}

            // Infinite loop fixed with boolean logic:
            while(infinite)
            {
                Console.WriteLine("Hey, this only iterates once.");
                infinite = false;
            }
            Console.WriteLine("\n");

            // Assignment 3:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 3: ----------------------------------------");
            int[] intArray = { 10, 20, 30, 40, 50, 60 };

            // Loop using "<"
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            // Loop using "<="
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("\n");

            // Assignment 4:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 4: ----------------------------------------");
            List<string> stringList = new List<string> { "This", "is", "a", "list", "of", "strings." };
            bool searchInList = false;

            Console.WriteLine("Please input some text to search for in my list:");
            string userSearch = Console.ReadLine();
            for (int i = 0; i < stringList.Count; i++)
            {
                if (userSearch == stringList[i])
                {
                    Console.WriteLine("That text appears at index " + i);
                    searchInList = true;
                    break;
                }
            }
            if (searchInList == false)
            {
                Console.WriteLine("I'm sorry, your search did not appear in the list.");
            }
            Console.WriteLine("\n");

            // Assignment 5:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 5: ----------------------------------------");
            List<string> stringList2 = new List<string> { "This", "This", "is", "is", "another", "another", "list.", "list." };
            bool searchInList2 = false;

            Console.WriteLine("Please input some text to search for in my list:");
            string userSearch2 = Console.ReadLine();
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (userSearch2 == stringList2[i])
                {
                    Console.WriteLine("That text appears at index " + i);
                    searchInList2 = true;
                }
            }
            if (searchInList2 == false)
            {
                Console.WriteLine("I'm sorry, your search did not appear in the list.");
            }
            Console.WriteLine("\n");

            // Assignment 6:  ---------------------------------------------------------------------
            Console.WriteLine("Assignment 6: ----------------------------------------");
            List<string> stringList3 = new List<string> { "This", "This", "is", "is", "another", "another", "list.", "list." };
            List<string> duplicateList = new List<string>();

            // Checks if item is unique or a duplicate:
            foreach (string item in stringList3)
            {
                if (duplicateList.Contains(item))
                {
                    Console.WriteLine((item) + " - This item is a duplicate.");
                    duplicateList.Add(item);
                }
                else
                {
                    Console.WriteLine((item) + " - This item is unique.");
                    duplicateList.Add(item);
                }
                
            }

            Console.ReadLine();
        }
    }
}
