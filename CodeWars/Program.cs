namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number1 = 0; //better write unit tests

            int result = MathematicalOperations.DigitalRoot(number1);
            Console.WriteLine(result);

            int n = -1; //false
            int n1 = 0; //true  
            int n2 = 3; //false
            int n3 = 4; //true  
            int n4 = 25; //true

            bool isSquare = MathematicalOperations.IsSquare(n4);
            Console.WriteLine(isSquare);
        }
    }
}
