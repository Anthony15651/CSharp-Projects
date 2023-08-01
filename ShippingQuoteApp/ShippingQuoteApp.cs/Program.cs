using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp.cs
{
    class Program
    {
        static void Main()
        {
            // Greets user and gets package weight
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of your package:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());


            // Checks if package is too heavy to ship
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // Get package length / width / height from user
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int packageTotal = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            decimal packageCost = Convert.ToDecimal(packageTotal);
            Console.WriteLine("Your estimated total for shipping this package is: $" + packageCost + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
