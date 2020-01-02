using System;

namespace Problem_02_Dot
{
    public class Dot3D : Dot2D
    {
        private double z;

        public double Z
        {
            get { return this.z; }
        }

        public Dot3D() : base()
        {
            Console.Write("z = ");
            this.z = double.Parse(Console.ReadLine());
        }

        public Dot3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public override void ShowCoordinates()
        {
            Console.WriteLine($"(x, y, z) = ({this.x}, {this.y}, {this.z})");
        }
    }
}
