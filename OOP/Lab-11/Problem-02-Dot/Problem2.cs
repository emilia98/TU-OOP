namespace Problem_02_Dot
{
    class Problem2
    {
        static void Main()
        {
            Dot2D dot2D_1 = new Dot2D();
            dot2D_1.ShowCoordinates();

            Dot2D dot2D_2 = new Dot2D(2, -5);
            dot2D_2.ShowCoordinates();

            Dot3D dot3D_1 = new Dot3D();
            dot3D_1.ShowCoordinates();

            Dot2D dot3D_2 = new Dot3D(7, -2.5, -3.6);
            dot3D_2.ShowCoordinates();
        }
    }
}
