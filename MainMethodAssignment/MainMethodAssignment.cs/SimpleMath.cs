using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs
{
    public class SimpleMath
    {
        public SimpleMath()
        {

        }
        public int NumberValue { get; set; }

        // Function for adding integers
        public int Addition(int x)
        {
            return (x + 10);
        }

        // Function for subtracting decimals
        public int Addition(decimal x)
        {
            // Converting result from decimal to int
            int decimalResult = Convert.ToInt32(x - 10);

            // Returning variable as an integer
            return (decimalResult);
        }

        // Function for converting and adding strings
        public int Addition(string x)
        {
            try
            {
                // Converting result from string to int
                int stringResult = Convert.ToInt32(x + 50);

                // Console.WriteLine(stringResult.GetType());

                // Returning variable as an integer
                return (stringResult);
            }
            catch
            {
                Console.WriteLine("The string entered could not be converted to an integer.");
            }
            finally
            {

            }
            return (50);
            
        }
    }
}
