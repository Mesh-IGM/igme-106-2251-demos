namespace Week1Demo
{
    // This class is intentionally uncommented. It is up to you to determine how it works.
    public class Circle : Shape
    {
        private int _radius;

        public Circle(int radius) : base("Circle")
        {
            _radius = radius;
        }

        public Circle(CustomRNG rng)
            : this(rng.Next(Shape.MinSize, Shape.MaxSize + 1))
        {
        }


        public override double Area
        {
            get
            {
                return Math.PI * _radius * _radius;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * _radius;
            }
        }

        public override void Scale(double factor)
        {
            _radius = (int)(_radius * factor);
        }


        public override void Draw()
        {
            for (int y = -_radius; y <= _radius; y++)
            {
                for (int x = -_radius; x <= _radius; x++)
                {
                    if (Math.Abs(x) * Math.Abs(x) + Math.Abs(y) * Math.Abs(y) <= _radius * _radius)
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
