using System;

namespace Problem_01_Figures_02
{
    class Figures_2
    {
        static void Main()
        {
            Circle c1 = new Circle();
            Console.WriteLine($"Circle with radius = {c1.Radius} and Area = {c1.Area()}");

            Circle c2 = new Circle(5);
            Console.WriteLine($"Circle with radius = {c2.Radius} and Area = {c2.Area()}");

            Console.WriteLine();

            Cone cone_1 = new Cone();
            Console.WriteLine($"Cone with radius = {cone_1.Radius}; height = {cone_1.Height} and Volume = {cone_1.Volume()}");

            Cone cone_2 = new Cone(10, 5);
            Console.WriteLine($"Cone with radius = {cone_2.Radius}; height = {cone_2.Height} and Volume = {cone_2.Volume()}");

            Console.WriteLine();

            Cylinder cylinder_1 = new Cylinder();
            Console.WriteLine($"Cylinder with radius = {cylinder_1.Radius}; height = {cylinder_1.Height} and Volume = {cylinder_1.Volume()}");

            Cylinder cylinder_2 = new Cylinder(10, 5);
            Console.WriteLine($"Cylinder with radius = {cylinder_2.Radius}; height = {cylinder_2.Height} and Volume = {cylinder_2.Volume()}");
        }
    }
}
