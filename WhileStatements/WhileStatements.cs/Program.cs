using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatements.cs
{
    class Program
    {
        static void Main()
        {
            int guesses = 0;

            // First while loop (runs 3 times)
            while (guesses != 3)
            {
                Console.WriteLine("Guess a number!");
                int guess = Convert.ToInt32(Console.ReadLine());
                guesses += 1;
            }

            Console.WriteLine("Good guesses!");

            // Second while loop (runs until number is guessed correctly)
            Console.WriteLine("What number am I thinking of (between 1 - 5)?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = false;

            do
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("Correct, 3 was the number I was thinking of!");
                        number = Convert.ToInt32(Console.ReadLine());
                        numberGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that was not the number I was thinking of.\nPlease guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!numberGuessed);
            Console.Read();
        }
    }
}
