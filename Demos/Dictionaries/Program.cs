namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Player> playersDictionary =
               new Dictionary<String, Player>();

            // Create Player objects
            Player pax = new Player("Pax the Dog", 200);
            Player shiro = new Player("Shiro the Cat", 9872);

            // Add via Add method
            playersDictionary.Add("Pax", pax);

            // Add via direct index
            playersDictionary["Shiro"] = shiro;

        }
    }
}
