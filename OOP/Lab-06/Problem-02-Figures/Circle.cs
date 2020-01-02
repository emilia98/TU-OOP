using System;

namespace Problem_02_Figures
{
    public class Circle
    {
        private double radius = 1;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double FindArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
}
