using System.Runtime.CompilerServices;
using System.Net.Http.Headers;


[assembly: InternalsVisibleTo("TestProject")]

namespace CodeWars
{
    internal static class MathematicalOperations
    {

        //Method that calculates digital root (recursive sum of all the digits in a number). 
        public static int DigitalRoot(long n)
        {
            try
            {
                int digitalRoot = 0;

                foreach (char c in n.ToString())
                {
                    if (int.TryParse(c.ToString(), out int digit))
                        digitalRoot += digit;
                }
                return digitalRoot > 9 ? DigitalRoot(digitalRoot) : digitalRoot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
        //Method that defines if a number is a square number
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}