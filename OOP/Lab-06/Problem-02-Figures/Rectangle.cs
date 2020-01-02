namespace Problem_02_Figures
{
    public class Rectangle
    {
        // Field
        private double a = 1;

        // Field
        private double b = 1;

        public Rectangle()
        {
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double FindArea()
        {
            return this.a * this.b;
        }
    }
}
