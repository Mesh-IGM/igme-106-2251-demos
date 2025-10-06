namespace PE_LinkedLists
{
    /// <summary>
    /// Player class supplied by Prof. Mesh. to help test sorted collection implementations.
    /// DO NOT MODIFY THIS CODE
    /// 
    /// Player implements IComparable so that is will work when we start using it in sorted collections!
    /// https://docs.microsoft.com/en-us/dotnet/api/system.icomparable 
    /// </summary>
    class Player : IComparable
    {
        // Auto-properties for the name and score
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        public string Name { get; set; }
        public int Score { get; set; }

        // Parameterized constructor to set the Name and Score
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        /// <summary>
        /// Compares the given obj to this instance of a Player
        /// </summary>
        /// <returns>
        /// -1 if obj is a Player whose score is less than this Player's score
        /// 0 if obj is a Player and the names match OR if the scores match
        /// 1 if obj is a Player whose score is greater than this Player's score
        /// </returns>
        /// <throws>An ArgumentException if obj isn't a Player</throws>
        public int CompareTo(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;
                if (this.Name == other.Name || this.Score == other.Score)
                {
                    return 0;
                }
                else if (this.Score < other.Score)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

            // This shouldn't ever happen given the Main() provided, but its the right thing to
            // do when we get a situation we can't handle. We'll talk more about how to throw
            // your own exceptions later in the semester.
            throw new ArgumentException(String.Format("{0} is not an instance of {1}", obj, this.GetType()));
        }

        /// <summary>
        /// Return a string representing this Player object
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0} with a score of {1}", Name, Score);
        }
    }
}
