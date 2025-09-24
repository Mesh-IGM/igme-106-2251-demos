namespace Exam1_Review
{

    // Write the code to declare an enum of type Platform
    // with the following 3 states: stationary, floating and moving.
    enum Platform
    {
        Stationary, 
        Floating,
        Moving
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref types
            Player a = new Player("Lacey");
            Player b = a;
            //a.Name = null;
            a.Name = "Lacy";
            Console.WriteLine(b.Name);

            // Value types
            int nA = 13;
            int nB = nA;
            nA++;
            Console.WriteLine(nB);

            DoStuff(a);

            DoRecursiveThing(3);
        }

        public static int DoRecursiveThing(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n * n + DoRecursiveThing(n - 1);
            }
        }


        static void DoStuff(Player param)
        {
            Player localA = new Player("Shiro");
            int nB = 13;
        }
    }
}
