namespace Problem_01_Rectangle
{
    public class Rectangle
    {
        // field
        private double height;

        // field
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public Rectangle()
        {
            this.height = 1;
            this.width = 1;
        }

        public double Height
        {
            set { this.height = value; }
        }

        public double Width
        {
            set { this.width = value; }
        }

        public double Area
        {
            get { return this.height * this.width; }
        }
    }
}
