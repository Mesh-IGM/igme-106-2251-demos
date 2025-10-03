using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Player
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Player(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
