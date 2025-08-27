namespace Week1Demo
{
    // This class is intentionally uncommented. It is up to you to determine how it works.
    public abstract class Shape
    {
        public const int MinSize = 1;
        public const int MaxSize = 15;

        public string Type { protected set; get; }

        protected Shape(string type)
        {
            Type = type;
        }

        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public abstract void Draw();

        public abstract void Scale(double factor);

        public override string ToString()
        {
            return $"{Type} - A: {Area:F2}, P: {Perimeter:F2}";
        }
    }
}
