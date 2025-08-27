namespace Week1Demo
{
    // This is intentionally uncommented. It is up to you to determine how it works.
    internal class ShapeList
    {
        private Shape[] _shapes;

        public int Count { get; private set; }

        private const int InitialSize = 4;

        public int Capacity
        {
            get
            {
                return _shapes.Length;
            }
        }

        public int TotalArea
        {
           get
           {
                int totalArea = 0;
                for (int i = 0; i < Count; i++)
                {
                    totalArea += (int)_shapes[i].Area;
                }
                return totalArea;
            }
        }

        public int TotalPerimeter
        {
            get
            {
                int totalPerimeter = 0;
                for (int i = 0; i < Count; i++)
                {
                    totalPerimeter += (int)_shapes[i].Perimeter;
                }
                return totalPerimeter;
            }
        }

        public ShapeList(int initSize = InitialSize)
        {
            _shapes = new Shape[initSize];
            Count = 0;
        }

        public void Add(Shape shape)
        {
            if (Count == _shapes.Length)
            {
                // It would be more concise to use Array.Resize here, but we want you to see it written out
                Shape[] newList = new Shape[_shapes.Length * 2];
                for (int i = 0; i < _shapes.Length; i++)
                {
                    newList[i] = _shapes[i];
                }
                _shapes = newList;
            }
            _shapes[Count++] = shape;
        }

        public Shape GetAt(int index)
        {
            return _shapes[index];
        }

        public Shape RemoveAt(int index)
        {
            Shape shape = _shapes[index];
            for (int i = index; i < Count - 1; i++)
            {
                _shapes[i] = _shapes[i + 1];
            }
            Count--;
            return shape;
        }

        public void Clear()
        {
            Count = 0;
        }

        public override string ToString()
        {
            return "There are " + Count + " shapes in the list." +
                "\n\tTotal area: " + TotalArea +
                "\n\tTotal perimeter: " + TotalPerimeter + "\n";
        }

        public void PrintAll()
        {
            Console.WriteLine(this);
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_shapes[i]}");
            }
        }

        public void ScaleAll(double factor)
        {
            for (int i = 0; i < Count; i++)
            {
                _shapes[i].Scale(factor);
            }
        }
    }
}
