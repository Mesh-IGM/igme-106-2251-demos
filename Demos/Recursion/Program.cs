namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive: " + RecursiveFactorial(5));
            Console.WriteLine("Iterative: " + IterativeFactorial(5));
        }

        public static int RecursiveFactorial(int n)
        {
            // Base case
            if (n <= 1)
            {
                return 1;
            }

            // recursive case with state change to move n towards 1
            return n * RecursiveFactorial(n - 1);
        }

        public static int IterativeFactorial(int n)
        {
            int result = 1;

            for(int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }


    }
}
