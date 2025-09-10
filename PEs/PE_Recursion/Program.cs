namespace PE_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local variables for testing our recursive methods
            const int NumElements = 5;
            int[] nums = new int[NumElements];
            int[] numsReverse = new int[NumElements];
            int[] numsRandom = new int[NumElements];
            Random rng = new Random();
            string word;

            // Setup 3 arrays - nums in order, nums in reverse order, nums with random values
            for (int i = 0; i < NumElements; i++)
            {
                nums[i] = i;
                numsReverse[i] = NumElements - i - 1;
                numsRandom[i] = rng.Next(0, NumElements * 3);
            }

            // Put the number 42 at a random location in the non-random arrays
            nums[rng.Next(NumElements)] = 42;
            numsReverse[rng.Next(NumElements)] = 42;

            // Print each array
            PrintArray("In order", nums);
            PrintArray("In reverse", numsReverse);
            PrintArray("Random", numsRandom);
            Console.WriteLine();

            /* UNCOMMENT IN CHUNKS TO TEST


// Calc the factorial of each random number
for (int i = 0; i < NumElements; i++)
{
    Console.WriteLine($"{numsRandom[i]}! = {Factorial(numsRandom[i])}");
}
Console.WriteLine();

// Sum the elements of each array
Console.WriteLine($"Sum of nums is {Sum(nums)}");
Console.WriteLine($"Sum of numsReverse is {Sum(numsReverse)}");
Console.WriteLine($"Sum of numsRandom is {Sum(numsRandom)}");
Console.WriteLine();

// Find if the number 3 is in each array
Console.WriteLine($"Contains 3 in nums: {Contains(nums, 3)}");
Console.WriteLine($"Contains 3 in numsReverse: {Contains(numsReverse, 3)}");
Console.WriteLine($"Contains 3 in numsRandom: {Contains(numsRandom, 3)}");
Console.WriteLine();

// Find if the number 42 is in each array
Console.WriteLine($"Contains 42 in nums: {Contains(nums, 42)}");
Console.WriteLine($"Contains 42 in numsReverse: {Contains(numsReverse, 42)}");
Console.WriteLine($"Contains 42 in numsRandom: {Contains(numsRandom, 42)}");
Console.WriteLine();

// Prompt the user for a word to test string methods
Console.WriteLine("Enter a word:");
word = Console.ReadLine();
Console.WriteLine($"Is {word} a palindrome? {IsPalindrome(word)}");
Console.WriteLine($"Reverse of {word} is {Reverse(word)}");

*/
        }

        // PrintArray("In order", nums);
        // In order: 0 1 2 3 42
        static void PrintArray(string instr, int[] nums)
        {
            Console.Write(instr+": ");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
