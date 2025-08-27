namespace ConsoleApp_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello "+SmartConsole.Prompt("What's your name?"));
            SmartConsole.PrintSuccess("Let's go!");
        }
    }
}
