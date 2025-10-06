namespace PE_LinkedLists
{
    /// <summary>
    /// A custom linked list.
    /// </summary>
    /// <typeparam name="T">This list is NOT sorted, but it requires types to implement IComparable
    /// so that later we can wrap this and make a custom sorted LL</typeparam>
    class MyLinkedList<T> where T : IComparable
    {
        // *******************************************************************************
        // DO NOT CHANGE/ADD TO THE CLASS FIELDS!
        // *******************************************************************************

        // Don't want to lose the chain of nodes, so track the head of the chain
        private MyLinkedNode<T> head = null;

        // *******************************************************************************
        // Properties and indexers
        // *******************************************************************************

        /// <summary>
        /// Auto-properties automatically create backing fields for us. In this case,
        /// it it only allows the underlying field for the count to be set within this
        /// class.
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Add an indexer that allows get and set access to the data within 
        /// an existing node by index. For both get & set, make sure to throw an 
        /// IndexOutOfRangeException if the index given is out of range based on 
        /// the current count of the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                return default(T); // tmp
                // TODO: Implement the get for the indexer
                // Check the index

                // Start at the head

                // Hop down the chain index # of times

                // Return the data where we stopped
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            }
            set
            {
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // TODO: Implement the set for the indexer
                // Check the index

                // Start at the head

                // Hop down the chain index # of times

                // Set the data where we stopped
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            }
        }

        /// <summary>
        /// Add a new node with given data to the END of the list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // TODO: Implement the Add method
            // Adding to an empty list, set the head

                // Adding to the end of a non - empty list!
                // We need to find the end first - and we have to start at head to do that

                // Hop down the chain of nodes until we hit the end (i.e. the node with no next)

                // Now make that last node refer to the new one

            // No matter how we added, update the count
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }

        /// <summary>
        /// Look for the node with a specific piece of data and remove it
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            return false; // tmp
            // TODO: Implement the Remove method
            // Quit if nothing to remove

            // If the data is at the head, change head to reference head's Next, 
            // reduce the count, and return true

            // If it's after head (anywhere after head), we have to search for it

            // Hop down the chain checking if we found what to remove as we go

                // We actually want to check if we're removing the node AFTER the one
                // we're currently on.

            // If we got this far, we didn't find anything to remove
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }

        /// <summary>
        /// Clear the LL by abandoning all the nodes
        /// </summary>
        public void Clear()
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // TODO: Implement the Clear method. You do NOT need a loop here!!!
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }
    }
}
