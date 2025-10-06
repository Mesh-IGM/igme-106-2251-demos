namespace PE_LinkedLists
{
    // DO NOT MODIFY ANY CODE IN THIS CLASS
    class MyLinkedNode<T> where T : IComparable
    {
        // Nodes contain 2 pieces of data: the data for the node and a reference to
        // the next node in the list. They have public get/set auto-properties for these
        // so that the main LL class can manage them.

        /// <summary>
        /// The data for this node
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// The next node in the chain
        /// </summary>
        public MyLinkedNode<T> Next { get; set; }

        /// <summary>
        /// Create a new node with the given data and no connections
        /// </summary>
        /// <param name="data"></param>
        public MyLinkedNode(T data)
        {
            Data = data;
            Next = null; // it would be by default, but let's be explicit
        }

        /// <summary>
        /// The string representation for this node's data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
