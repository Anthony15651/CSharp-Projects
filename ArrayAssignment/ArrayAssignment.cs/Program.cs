using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Creating an array of strings
        string[] myStringArray = { "This", "is", "an", "array", "of", "strings." };
        Console.WriteLine("Please select an index of the Array, and I will display the string associated with it.");
        int userInt = Convert.ToInt32(Console.ReadLine());

        // Checks to make sure user input is a valid index
        while (userInt > 5)
        {
            Console.WriteLine("I'm sorry, the array is not that large. Please select an index between 1 - 5.");
            userInt = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine(myStringArray[userInt]);



        // Creating an array of integers
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Please select an index of the Array, and I will display the number associated with it.");
        userInt = Convert.ToInt32(Console.ReadLine());

        // Checks to make sure user input is a valid index
        while (userInt > 4)
        {
            Console.WriteLine("I'm sorry, the array is not that large. Please select an index between 1 - 4.");
            userInt = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine(myIntArray[userInt]);
        Console.ReadLine();
    }
}

