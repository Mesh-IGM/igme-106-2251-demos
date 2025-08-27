namespace Week1Demo
{
    internal class Program
    {
        /// <summary>
        /// Main runs our various test methods.
        /// </summary>
        static void Main(string[] args)
        {
            CustomRNG rng = new CustomRNG();
            //TestRNG(rng);
            TestShapes(rng);
        }

        private static void TestShapes(CustomRNG rng)
        {
            ShapeList myShapes = new ShapeList();
            double[] weights = null;
            string[] shapes = { "Circle", "Rectangle", "Triangle" };

            while(true) // This is one of the VERY few cases where a while(true) loop is acceptable
                        // and ONLY because we want the method to end when the loop ends so we use a return.
            {
                Console.WriteLine(  "\n1. Add a Circle"+
                                    "\n2. Add a Rectangle"+
                                    "\n3. Add a Triangle"+
                                    "\n4. Add a surprise shape"+
                                    "\n5. Print all" +
                                    "\n6. Draw" +
                                    "\n7. Remove" +
                                    "\n8. Resize all" +
                                    "\n9. Exit");
                int choice = SmartConsole.Prompt("\nEnter your choice: ", 1, 9);
                switch (choice)
                {
                    case 1:
                        myShapes.Add(new Circle(SmartConsole.Prompt("\nEnter the radius: ", Shape.MinSize, Shape.MaxSize)));
                        break;
                    case 2:
                        myShapes.Add(new Rectangle(SmartConsole.Prompt("\nEnter the width: ", Shape.MinSize, Shape.MaxSize), SmartConsole.Prompt("Enter the height: ", Shape.MinSize, Shape.MaxSize)));
                        break;
                    case 3:
                        myShapes.Add(new Triangle(SmartConsole.Prompt("\nEnter the width: ", Shape.MinSize, Shape.MaxSize), SmartConsole.Prompt("Enter the height: ", Shape.MinSize, Shape.MaxSize)));
                        break;
                    case 4:
                        while(weights == null)
                        {
                            weights = new double[3];
                            for(int i = 0; i < weights.Length; i++)
                            {
                                weights[i] = SmartConsole.Prompt($"Enter the % of {shapes[i]}s: ", 0.0, 1.0);
                            }
                            // test that the weights are valid
                            try
                            {
                                int test = rng.NextWeightedInt(0, 3, weights);
                            }
                            catch
                            {
                                SmartConsole.PrintError("Invalid weights. Please try again.");
                                weights = null;
                            }
                        }
                        Shape newShape = null;
                        switch(rng.NextWeightedInt(0, 3, weights))
                        {
                            case 0:
                                newShape = new Circle(rng);
                                break;
                            case 1:
                                newShape = new Rectangle(rng);
                                break;
                            case 2:
                                newShape = new Triangle(rng);
                                break;
                        }
                        myShapes.Add(newShape);
                        Console.WriteLine($"Added {newShape}");
                        break;
                    case 5:
                        myShapes.PrintAll();
                        break;
                    case 6:
                        myShapes.PrintAll();
                        myShapes.GetAt(SmartConsole.Prompt("\nWhich shape do you want to draw? ", 1, myShapes.Count)-1).Draw();
                        break;
                    case 7:
                        myShapes.PrintAll();
                        myShapes.RemoveAt(SmartConsole.Prompt("\nWhich shape do you want to remove? ", 1, myShapes.Count)-1);
                        break;
                    case 8:
                        myShapes.ScaleAll(SmartConsole.Prompt("\nEnter the factor to resize by: ", 0.0, 1.0));
                        break;
                    case 9:
                        return;
                }
            }
            // If we wanted to do ANYTHING after the loop, the early return would be a bad idea.
        }

        private static void TestRNG(CustomRNG rng)
        {
            // Create a new instance of CustomRNG & weights
            double[] weights = { 0.1, 0.1, 0.1, 0.7 };

            SmartConsole.PrintSuccess("\n5 random ints of the default range");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rng.Next()+" ");
            }
            Console.WriteLine();

            SmartConsole.PrintSuccess("\n10 random ints with [3,27)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rng.Next(3, 27) + " ");
            }
            Console.WriteLine();

            SmartConsole.PrintSuccess("\n10 random doubles of the default range");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0:F3} ", rng.NextDouble());
            }
            Console.WriteLine();

            SmartConsole.PrintSuccess("\n10 random doubles with [3,27)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0:F3} ", rng.NextDouble(3, 27));
            }
            Console.WriteLine();

            SmartConsole.PrintSuccess("\n10 random ints with weights (0.1, 0.2, 0.3, 0.4) in the range [21, 25)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rng.NextWeightedInt(21, 25, weights) + " ");
            }
            Console.WriteLine();
        }

    }
}
