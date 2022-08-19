namespace ShapeHierarchy
{
    public class Segment : Shape
    {
        public Segment(Point a, Point b)
        {
            this.a = a;
            this.b = b;
            length = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        private Point a;
        private Point b;
        private double length;

        public double Length => length;
    }
}
