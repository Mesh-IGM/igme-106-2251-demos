namespace PE_AlgorithmAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two MyList objects - one sorted, one unsorted.
            MyList sortedList = new MyList(true);
            MyList unsortedList = new MyList(false);

            // Create a random number generator and set up constants to configure the tests
            Random rng = new Random();
            const int MinValue = 0;
            const int MaxValue = 10000;
            const int NumValues = 50; // Has to be at least 6 for the tests below to work.

            // TODO: Try changing NumValues a few times to see how the time to add changes
            // as the number of elements in the list increases.

            // Local variable to capture times
            DateTime start;
            DateTime end;

            // Add 42 to both lists at the start
            sortedList.Add(42);
            unsortedList.Add(42);

            // Fill the sorted list with random values.
            start = DateTime.Now;
            for (int i = 0; i < NumValues; i++)
            {
                sortedList.Add(rng.Next(MinValue, MaxValue + 1));
            }
            end = DateTime.Now;
            Console.WriteLine("Time to add " + NumValues + " values to sorted list: " + (end - start));
            Console.WriteLine("\t Average time per value: " + (end - start).TotalMilliseconds / NumValues + "ms");
            Console.WriteLine();

            // Fill the unsorted list with random values.
            start = DateTime.Now;
            for (int i = 0; i < NumValues; i++)
            {
                unsortedList.Add(rng.Next(MinValue, MaxValue + 1));
            }
            end = DateTime.Now;
            Console.WriteLine("Time to add " + NumValues + " values to unsorted list: " + (end - start));
            Console.WriteLine("\t Average time per value: " + (end - start).TotalMilliseconds / NumValues + "ms");
            Console.WriteLine();

            // Try to insert a value at a specific index in each list.
            // It should work for the unsorted list, but not the sorted list.
            unsortedList.Insert(5, 120);

            try
            {
                sortedList.Insert(5, 120);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Caught exception: " + e.Message);
            }
            Console.WriteLine();

            // Try to set the last value in each list to a new value. Getting the Count should
            // work for both lists, but setting the value should only work for the unsorted list.
            unsortedList.Set(unsortedList.Count - 1, 99);

            try
            {
                sortedList.Set(sortedList.Count - 1, 99);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Caught exception: " + e.Message);
            }
            Console.WriteLine();

            // Repeatedly try to find the index of MinValue, MaxValue, and a random value in the unsorted
            // list for NumValues iterations. Then do the same for the sorted list.
            start = DateTime.Now;
            for (int i = 0; i < NumValues; i++)
            {
                unsortedList.IndexOf(MinValue);
                unsortedList.IndexOf(MaxValue);
                unsortedList.IndexOf(rng.Next(MinValue, MaxValue + 1));
            }
            end = DateTime.Now;
            Console.WriteLine("Time to find values in unsorted list: " + (end - start));
            Console.WriteLine("\t Average time per value: " + (end - start).TotalMilliseconds / (NumValues * 3) + "ms");
            Console.WriteLine();

            start = DateTime.Now;
            for (int i = 0; i < NumValues; i++)
            {
                sortedList.IndexOf(MinValue);
                sortedList.IndexOf(MaxValue);
                sortedList.IndexOf(rng.Next(MinValue, MaxValue + 1));
            }
            end = DateTime.Now;
            Console.WriteLine("Time to find values in sorted list: " + (end - start));
            Console.WriteLine("\t Average time per value: " + (end - start).TotalMilliseconds / (NumValues * 3) + "ms");
            Console.WriteLine();

            // TODO: How does the time to find the index of a value change as the value of NumValues increases?
        }
    }
}
