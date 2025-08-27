namespace ConsoleApp_Sample
{
    /// <summary>
    /// Class to hold static helper methods related to prompting for 
    /// and parsing, validating, and returning user responses.
    /// 
    /// Do NOT change anything!
    /// </summary>
    public static class SmartConsole
    {
        /// <summary>
        /// Prints an success message in green to the console.
        /// </summary>
        /// <param name="message">The success message to display.</param>
        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Prints an error message in red to the console.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Prints a warning message in dark yellow to the console.
        /// </summary>
        /// <param name="message">The warning message to display.</param>
        public static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Helper method to prompt the user to enter a number. If their
        /// response isn't a valid int or isn't in the desired range, reprompt
        /// </summary>
        /// <param name="prompt">The string to use in the initial prompt</param>
        /// <param name="min">The minimum accepted value (inclusive)</param>
        /// <param name="max">The maximum accepted value (inclusive)</param>
        /// <returns>The final, valid, user-entered value.</returns>
        public static int Prompt(string prompt, int min, int max)
        {
            int result = 0;
            while (!int.TryParse(Prompt(prompt), out result) || result < min || result > max)
            {
                prompt = $"\tPlease enter a valid whole number between {min} and {max}:";
            }
            return result;
        }

        /// <summary>
        /// Helper method to prompt the user to enter a number. If their
        /// response isn't a valid int or isn't in the desired range, reprompt
        /// </summary>
        /// <param name="prompt">The string to use in the initial prompt</param>
        /// <param name="min">The minimum accepted value (inclusive)</param>
        /// <param name="max">The maximum accepted value (inclusive)</param>
        /// <returns>The final, valid, user-entered value.</returns>
        public static double Prompt(string prompt, double min, double max)
        {
            double result = 0;
            while (!double.TryParse(Prompt(prompt), out result) || result < min || result > max)
            {
                prompt = $"\tPlease enter a valid number between {min:F2} and {max:F2}:";
            }
            return result;
        }

        /// <summary>
        /// Given a reference to an array of possible choices, keep prompting
        /// the user until they enter a valid option
        /// NOTE: Validation assumes lower case choices!
        /// DO NOT TOUCH THIS METHOD!
        /// </summary>
        /// <param name="prompt">The prompt to use</param>
        /// <param name="choices">The valid options</param>
        /// <returns>The final valid choice</returns>
        public static char Prompt(string prompt, char[] choices)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(prompt + " ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            char result = Console.ReadKey().KeyChar; // Get JUST 1 character
            Console.ForegroundColor = ConsoleColor.White;

            // We haven't taught using Predicates in parameters. There are ways to implement
            // this with what you've learned so far, but we didn't feel like making you worry about
            // anything not related to exceptions or TryParse for this PE.
            // https://learn.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-7.0
            while (!Array.Exists(choices, element => element == result))
            {
                Console.WriteLine("\nCommand not recognized.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n" + prompt + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                result = char.ToLower(Console.ReadKey().KeyChar); // Get JUST 1 character
                Console.ForegroundColor = ConsoleColor.White;
            }
            return result;
        }

        /// <summary>
        /// Uses the given string to prompt the user for input and set
        /// the color to cyan while they type.
        /// DO NOT TOUCH THIS METHOD!
        /// </summary>
        /// <param name="prompt">What to print before waiting for input</param>
        /// <returns>A trimmed version of what the user entered</returns>
        public static string Prompt(string prompt)
        {
            // Always print in white
            Console.ForegroundColor = ConsoleColor.White;

            // Print the prompt
            Console.Write(prompt + " ");

            // Switch color and get user input (trim too)
            Console.ForegroundColor = ConsoleColor.Cyan;
            string response = Console.ReadLine().Trim();

            // Switch back to white and then return response.
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

    }
}
