namespace Week1Demo
{
    // This class is intentionally uncommented. It is up to you to determine how it works.
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height) : base("Rectangle")
        {
            _width = width;
            _height = height;
            if (_width == _height)
            {
                Type = "Square";
            }
        }

        public Rectangle(CustomRNG rng)
            : this(rng.Next(Shape.MinSize, Shape.MaxSize + 1), rng.Next(Shape.MinSize, Shape.MaxSize + 1))
        {
        }

        public override double Area
        {
            get
            {
                return _width * _height;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (_width + _height);
            }
        }

        public override void Scale(double factor)
        {
            _width = (int)(_width * factor);
            _height = (int)(_height * factor);
        }


        public override void Draw()
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
