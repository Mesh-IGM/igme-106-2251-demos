using System;

namespace Console_StructsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = AddNumbers(1, 2);
            c++;

            // AddNumbers(1, 2)++;

            MakePet().Name = "Shiro";

            
            // Create 3 different RGB color instances
            RGBColor red = new RGBColor(255, 0, 0);
            RGBColor green = new RGBColor(0, 255, 0);
            RGBColor blue = new RGBColor(0, 0, 255);

            Console.WriteLine("Red: " + red.R + ", " + red.G + ", " + red.B);
            Console.WriteLine("Green: " + green.R + ", " + green.G + ", " + green.B);
            Console.WriteLine("Blue: " + blue.R + ", " + blue.G + ", " + blue.B);
            Console.WriteLine();

            // Create a new color variable starting with blue and adding red
            // IF RGBColor is a class, blue changes too!
            RGBColor purple = blue;
            purple.R += red.R;
            purple.G += red.G;
            purple.B += red.B;

            Console.WriteLine("Purple: " + purple.R + ", " + purple.G + ", " + purple.B);
            Console.WriteLine();

            Console.WriteLine("Red: " + red.R + ", " + red.G + ", " + red.B);
            Console.WriteLine("Green: " + green.R + ", " + green.G + ", " + green.B);
            Console.WriteLine("Blue: " + blue.R + ", " + blue.G + ", " + blue.B);
            Console.WriteLine();
            
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static Pet MakePet()
        {
            return new Pet();
        }
    }
}
