namespace Week1Demo
{
    // This class is intentionally uncommented. It is up to you to determine how it works.
    internal class Triangle : Shape
    {
        private int _width;
        private int _height;

        public Triangle(int width, int height) : base("Triangle")
        {
            _width = width;
            _height = height;
        }

        public Triangle(CustomRNG rng)
            : this(rng.Next(Shape.MinSize, Shape.MaxSize + 1), rng.Next(Shape.MinSize, Shape.MaxSize + 1))
        {
        }

        public override double Area
        {
            get
            {
                return 0.5 * _width * _height;
            }
        }

        public override double Perimeter
        {
            get
            {
                return _width + 2 * Math.Sqrt(_height * _height + _width / 2 * (_width / 2));
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
                    if (x == 0 || y == _height - 1 || y == x * _height / _width)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
