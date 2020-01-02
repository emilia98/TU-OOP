using System;

namespace Problem_01_Rectangle
{
    class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Rectangle r3 = new Rectangle(5.2, 3.5);

            r1.Height = 8;
            r1.Width = 3;

            double r1_area = r1.Area;
            double r2_area = r2.Area;
            double r3_area = r3.Area;

            double maxArea = r1_area;

            if(r1_area < r2_area)
            {
                if(r2_area >= r3_area)
                {
                    maxArea = r2_area;
                }
                else
                {
                    maxArea = r3_area;
                }
            }
            else
            {
                if(r1_area < r3_area)
                {
                    maxArea = r3_area;
                }
            }


            Console.WriteLine($"Max Area = {maxArea:f2}");

            Console.WriteLine($"Area 1 = {r1_area}");
            Console.WriteLine($"Area 2 = {r2_area}");
            Console.WriteLine($"Area 3 = {r3_area}");
        }
    }
}
