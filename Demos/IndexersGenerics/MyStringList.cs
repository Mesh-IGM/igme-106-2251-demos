using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersGenerics
{
    class MyStringList
    {
        // The data for the list and a constant for the initial size
        private String[] rawData;
        private const int InitCapacity = 2;

        // auto-property where the get is public, but not the set
        public int Count { get; private set; }

        // index property
        public string this[int i]
        {
            get
            {
                Console.WriteLine($"Get {i}");
                // Ensure the index is valid
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException(
                      "Your index is bad");
                }

                return rawData[i];
            }

            set
            { 
                Console.WriteLine($"Set {i} to {value}");
                // Ensure the index is valid
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException(
                      "Your index is bad");
                }

                rawData[i] = value;
            }
        }

        // Creates a basic list
        public MyStringList()
        {
            rawData = new String[InitCapacity];
            Count = 0;
        }

        // Adds an item to the list
        public void Add(String item)
        {
            // If we're out of space, make a bigger array,
            // copy the data over, then make our data field refer
            // to the new, bigger array
            if (Count == rawData.Length)
            {
                string[] newData = new string[rawData.Length * 2];
                for (int i = 0; i < rawData.Length; i++)
                {
                    newData[i] = rawData[i];
                }
                rawData = newData;
            }

            // Add the new element & increment the count
            rawData[Count] = item;
            Count++;
        }
    }
}
