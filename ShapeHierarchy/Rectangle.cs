namespace ShapeHierarchy
{
    public class Rectangle : Poligon
    {
        public Rectangle(Segment a, Segment b, Segment c, Segment d)
        {
            if (a.Length != c.Length | b.Length != d.Length)
            {
                throw new Exception("противолежащие стороны прямоугольника не равны");
            }
            this.Segments.Add(a);
            this.Segments.Add(b);
            this.Segments.Add(c);
            this.Segments.Add(d);
        }

        public override void EnterSegmentInside(Point a, Point b)
        {
            InnerSegment = new Segment(a, b);
        }

        public override double GetSquare()
        {
            return Segments[0].Length * Segments[1].Length;
        }
    }
}
