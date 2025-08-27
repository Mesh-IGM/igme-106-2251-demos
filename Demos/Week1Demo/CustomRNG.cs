namespace Week1Demo
{
    /// <summary>
    /// Wraps the .NET Random class to provide the abili to generate
    /// other types of random values.
    /// </summary>
    public class CustomRNG
    {
        /// <summary>
        /// Create a single instance of Random to use for all random number generation.
        /// 
        /// Using an _ at the front of the variable name instead of a local variable.
        /// You aren't required to use this convention, but it can be helpful. (And 
        /// MonoGame, which we'll use later in the course, does this in it's 
        /// auto-generated code.)
        /// </summary>
        private Random _rng;

        /// <summary>
        /// Create a new instance of CustomRNG with a new Random instance.
        /// </summary>
        public CustomRNG()
        {
            _rng = new Random();
        }

        /// <summary>
        /// Create a new instance of CustomRNG with a new Random instance and a seed.
        /// </summary>
        public CustomRNG(int seed)
        {
            _rng = new Random(seed);
        }

        /// <summary>
        /// Return a random integer between the min (inclusive) and max (exclusive) values.
        /// If min isn't provided, it defaults to 0. If max isn't provided, it defaults to int.MaxValue.
        /// If min > max, the values are swapped.
        /// </summary>
        public int Next(int min = 0, int max = int.MaxValue)
        {
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
            return _rng.Next(min, max);
        }

        /// <summary>
        /// Return a random double between 0.0 and 1.0.
        /// </summary>
        public double NextDouble()
        {
            return _rng.NextDouble();
        }

        /// <summary>
        /// Return a random double between the min (inclusive) and max (exclusive) values.
        /// If min > max, the values are swapped.
        /// </summary>
        public double NextDouble(double min, double max)
        {
            if (min > max)
            {
                double temp = min;
                min = max;
                max = temp;
            }
            return _rng.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// Return a random int out of a range of values, with each value having a different weight.
        /// Return a random integer between the min (inclusive) and max (exclusive) values.
        /// If min > max, the values are swapped.
        /// The # of weights must match the range of values, and the weights must add up to 1.
        /// </summary>
        public int NextWeightedInt(int min, int max, double[] weights)
        {
            // Set up variables to track the total weight and the random weight for this run of the algorithm
            double totalWeight = 0;
            double randomValue = NextDouble();
            int result = 0;

            // Swap min and max if min > max
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            // Check to make sure the number of weights matches the range of values
            if (weights.Length != max - min)
            {
                throw new ArgumentException("The number of weights must match the range of values.");
            }

            // Check to make sure the weights add up to 1
            foreach (double weight in weights)
            {
                totalWeight += weight;
            }
            if (totalWeight != 1)
            {
                throw new ArgumentException("The total weight must be 1.");
            }

            // Count how many "buckets" are used up by the random value
            while (randomValue > 0)
            {
                randomValue -= weights[result];
                result++;
            }

            // Return the result
            return result + min - 1;
        }
    }
}
