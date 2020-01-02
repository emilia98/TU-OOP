using System;

namespace Problem_02_Figures
{
    class Program
    {
        static void Main()
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(1.2, 2.5);

            Console.WriteLine($"Rectangle 1 Area = {rect1.FindArea():f2}");
            Console.WriteLine($"Rectangle 2 Area = {rect2.FindArea():f2}");

            Circle circle1 = new Circle();
            Circle circle2 = new Circle(3.5);

            Console.WriteLine($"Circle 1 Area = {circle1.FindArea():f2}");
            Console.WriteLine($"Circle 2 Area = {circle2.FindArea():f2}");
        }
    }
}
