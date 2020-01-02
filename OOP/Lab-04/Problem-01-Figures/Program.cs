using System;

namespace Problem_01_Figures
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Rectangle rectangle = new Rectangle();

            rectangle.EnterSides();
            Console.WriteLine($"A = {rectangle.GetA}");
            Console.WriteLine($"B = {rectangle.GetB}");
            rectangle.FindArea();

            Console.WriteLine(new string('-', 25));

            Console.ForegroundColor = ConsoleColor.Magenta;

            Triangle triangle = new Triangle();
            
            triangle.EnterSides();
            Console.WriteLine($"A = {triangle.GetA}");
            Console.WriteLine($"B = {triangle.GetB}");
            Console.WriteLine($"C = {triangle.GetC}");

            if (triangle.IsValid())
            {
                triangle.FindArea();
            }

            Console.WriteLine(new string('-', 25));

            Console.ForegroundColor = ConsoleColor.Green;

            Circle circle = new Circle();

            circle.EnterRadius();
            Console.WriteLine($"Radius = {circle.GetRadius}");

            circle.FindArea();
        }
    }
}
