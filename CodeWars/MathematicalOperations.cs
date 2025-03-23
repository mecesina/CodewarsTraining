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
        //The method that calculates and returns the shortest number of steps to from num to 1 (given that 
        //one step is either num +=1 or num*=2
        public static int ShortestStepsToNum(int num)
        {
            int numberOfSteps = 0;
            for(int i = 10000; i >= 1; i--)
            {
                if (num == 1)
                    return 0;
                if (num % 2 != 0)
                {
                    num -= 1;
                    numberOfSteps++;
                    i = num;
                }
                num /= 2;
                numberOfSteps++;
                i = num;
            }
            return numberOfSteps;
        }
        //Method that reads the given instructions for calculation from char and outputs the values
        public static int[] IntepreteInstructions(string data)
        {
            int startPoint = 0;
            int outputCount = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 'o')
                    outputCount++;
            }

            int[] result = new int[outputCount];
            int index = 0;

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case 'i':
                        startPoint += 1;
                        break;
                    case 'd':
                        startPoint -= 1;
                        break;
                    case 's':
                        startPoint *= startPoint;
                        break;
                    case 'o':
                        result[index++] = startPoint;
                        break;
                }
            }
            return result;
        }
    }
}