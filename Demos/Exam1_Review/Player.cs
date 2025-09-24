using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Review
{
    internal class Player
    {
        private string name;
        private int id = 42;

        public string Name
        {
            get
            { 
                return name;
            }

            set
            {
                if (value != null && value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    throw new InvalidOperationException(
                        "Can't set the name to a null or empty string");
                }
            }
        }

        public Player(string name)
        {
            this.name = name;
        }
    }
}
