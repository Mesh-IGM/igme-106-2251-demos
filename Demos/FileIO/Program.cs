namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // This is ideally read in from a file
            String line = "Bob,Sword,5,8,9";
            Console.WriteLine();
            */

            // The file path is relative to the directory in which the program is
            // running. "<sln file folder>\FileIODemo\bin\Debug\net6.0" here.
            // The ..\..\..\ brings it up to the folder that your sln file is in
            // (The \ chars are also escaped)
            // https://docs.microsoft.com/en-us/dotnet/standard/io/file-path-formats  
            String filename = "..\\..\\..\\playerData.csv";


            // Create the variable outside the try
            // since we'll need it afterwards
            StreamReader reader = null;

            try
            {
                // Creating the stream reader opens the file
                reader = new StreamReader(filename);

                // Loop through the file, one line at a time
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Splitting '" + line + "'");

                    // We want to split up the string to
                    // isolate the individual pieces of data
                    String[] data = line.Split(',');

                    // Print out the data to ensure it works
                    /*
                    for (int i = 0; i < data.Length; i++)
                    {
                        Console.WriteLine("\t" + data[i]);
                    }
                    Console.WriteLine();
                    */

                    // If I want to make a player from this data,
                    // we can simply plug the data into the constructor
                    // in the correct order
                    Player p1 = new Player(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        int.Parse(data[3]),
                        int.Parse(data[4]));
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file: "
                    + e.Message);
            }

            // Ensure that we can close the file, as long
            // as it was actually opened in the first place
            if (reader != null)
            {
                reader.Close();
            }

        }
    }
}
