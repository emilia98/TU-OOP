using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_Rectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle<int> rectangle_1 = new Rectangle<int>(5, 6);
            rectangle_1.Area();
            Rectangle<float> rectangle_2 = new Rectangle<float>(2, 4);
            rectangle_2.A = 2.1f;
            rectangle_2.B = 4.1f;
            rectangle_2.Area();

            Rectangle<double> rectangle_3 = new Rectangle<double>();
            rectangle_3.Area();

            Rectangle<string> rectangle_4 = new Rectangle<string>("Hello", "World");
            rectangle_4.Area();
        }
    }
}
