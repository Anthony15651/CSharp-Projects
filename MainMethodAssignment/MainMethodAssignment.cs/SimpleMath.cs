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
        public decimal Addition(decimal x)
        {
            return (x - 10);
        }

        // Function for converting and adding strings
        public string Addition(string x)
        {
            try
            {
                int newInteger = Convert.ToInt32(x);
                newInteger += 50;
                string integerString = newInteger.ToString();
                return (integerString);
            }
            catch
            {
                Console.WriteLine("The string entered could not be converted to an integer.");
            }
            finally
            {
                
            }

            return (x + 50);
        }
    }
}
