using System;

/// <summary>
/// Program class with complete Main() supplied by Prof. Mesh.
/// DO NOT MODIFY THIS CODE
/// </summary>
namespace PE_LinkedLists
{
    class Program
    {
        /// <summary>
        /// Main calls the helpers to run the sorted list and LL tests
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Test the custom linked list with ints
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n" + "".PadLeft(20, '~') + " LL of ints " + "".PadLeft(20, '~'));

            // Create an empty LL and print the count to be sure it's empty:
            MyLinkedList<int> myInts = new MyLinkedList<int>();
            for (int i = 0; i < 25; i += 5)
            {
                myInts.Add(i);
            }

            Console.WriteLine("Total number of ints: " + myInts.Count);

            Console.WriteLine("Remove 15");
            myInts.Remove(15);

            for (int i = 0; i < myInts.Count; i++)
            {
                Console.WriteLine(" - " + myInts[i]);
            }

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Test the custom linked list with strings
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n" + "".PadLeft(20, '~') + " LL of strings " + "".PadLeft(20, '~'));

            // Create an empty LL and print the count to be sure it's empty:
            MyLinkedList<string> myPets = new MyLinkedList<string>();
            Console.WriteLine("Current number of pets: " + myPets.Count);

            // Add some pets and then print them out
            myPets.Add("Aiden");
            myPets.Add("Pax");
            myPets.Add("Shiro");
            myPets.Add("Lacey");
            Console.WriteLine("\nCurrent number of pets: " + myPets.Count);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(" - " + myPets[i]);
            }

            // Fix the spelling of Lacy's name
            myPets[3] = "Lacy";

            // Do some out of range stuff....
            try
            {
                Console.WriteLine(myPets[4]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Correctly got an exception from the indexer's get: " + e.Message);
            }

            try
            {
                myPets[4] = "Uh oh";
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Correctly got an exception from the indexer's set: " + e.Message);
            }

            // Remove Aiden since he doesn't live at my house
            myPets.Remove("Aiden");

            Console.WriteLine("\nCurrent number of pets: " + myPets.Count);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(" - " + myPets[i]);
            }

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Test the custom linked list with Players
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n" + "".PadLeft(20, '~') + " LL of players " + "".PadLeft(20, '~'));

            MyLinkedList<Player> myPlayers = new MyLinkedList<Player>();
            myPlayers.Add(new Player("Pax", 2));
            myPlayers.Add(new Player("Aiden", 17));
            myPlayers.Add(new Player("Lacy", 1));
            myPlayers.Add(new Player("Shiro", 4));
            myPlayers.Remove(new Player("Aiden", 0));

            Console.WriteLine("Current number of players: " + myPlayers.Count);
            for (int i = 0; i < myPlayers.Count; i++)
            {
                Console.WriteLine(" - " + myPlayers[i]);
            }
        }
    }
}
