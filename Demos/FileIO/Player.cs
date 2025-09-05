using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Player
    {
        // This is an example constructor
        public Player(String name, String weapon,
              int intel, int dex, int str)
        {
            Console.WriteLine("Sample constructor for " +
              "a Player with:\n" +
              "\tname = {0}, " +
              "\tweapon = {1}, " +
              "\tintel = {2}, " +
              "\tdex = {3}, " +
              "\tstr = {4}",
              name, weapon, intel, dex, str);
        }
    }
}
