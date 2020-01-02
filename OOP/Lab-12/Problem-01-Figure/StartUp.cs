using System;

namespace Problem_01_Figure
{
    class StartUp
    {
        static void Main()
        {
            Figure f;

            Console.WriteLine(new string('-', 15));
            Console.WriteLine("Square: 1");
            Console.WriteLine("Circle: 2");
            Console.WriteLine("Rhombus: 3");
            Console.WriteLine("Rectangle: 4");
            Console.WriteLine(new string('-', 15));

            Console.Write("Enter figure type: ");
            int type = Int32.Parse(Console.ReadLine());
            FigureType figureType = (FigureType)type - 1;

            switch(figureType)
            {
                case FigureType.square: f = new Square();
                        break;
                case FigureType.circle:
                    f = new Circle();
                    break;
                case FigureType.rhombus:
                    f = new Rhombus();
                    break;
                case FigureType.rectangle:
                    f = new Rectangle();
                    break;
                default:
                    f = null;
                    break;
            }

            if(f != null)
            {
                f.Input();
                f.Output();
                Console.WriteLine($"Area = {f.Area():f2}");
            }
        }
    }
}
