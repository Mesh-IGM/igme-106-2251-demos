namespace IntroDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1d array of names (strings)
            string[] ex1 = new string[5];
            ex1[2] = "Shiro";

            // 1d array of Pet objects
            Pet[] pets2 = new Pet[5];
            pets2[0] = new Pet();
            pets2[1] = new Pet("Lacy", 7.5);

            // List of arrays of varying sizes
            List<int[]> grades = new List<int[]>();
            grades.Add(new[] { 89, 87, 85 });
            grades.Add(new[] { 73, 75 });
            grades.Add(new[] { 88, 90, 92, 94, 99 });

            // 4 element array of Pet Lists
            List<Pet>[] familyPets = new List<Pet>[4];
            familyPets[2] = new List<Pet>();
            familyPets[2].Add(new Pet("Samson", 11.5));
            familyPets[3] = new List<Pet>();
            familyPets[3].Add(new Pet("Indy", 75));
            familyPets[3].Add(new Pet("Odin", 93));

            // Mini-Checkerboard
            // - 2d, symmetrical multidimension array
            //   where true means that square is red
            int size = 4;
            bool[,] board = new bool[size, size];
            for (int row = 0; row < size; row++)
            {
                // Figure out the first column's value
                board[row, 0] = row % 2 == 0;
                for (int col = 1; col < size; col++)
                {
                    // Each column in a row is the opposite of the previous
                    board[row, col] = !board[row, col - 1];
                }
            }

            bool[][] boolArrays = new bool[2][];
            boolArrays[0] = new bool[4];
            boolArrays[1] = new bool[8];
            Console.WriteLine(
                "# arrays in boolArrays: {0}\n" +
                "array 0 size: {1}\n" +
                "array 1 size: {2}",
                boolArrays.Length,
                boolArrays[0].Length,
                boolArrays[1].Length);

        }
    }
}
