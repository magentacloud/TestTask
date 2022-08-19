namespace ShapeHierarchy
{
    public class Point : Shape
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
    }
}
