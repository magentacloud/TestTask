namespace ShapeHierarchy
{
    public abstract class FlatShape : Shape
    {

        public abstract double GetSquare();

        public Segment InnerSegment
        {
            get { return InnerSegment; }
            internal set { InnerSegment = value; }
        }

        public abstract void EnterSegmentInside(Point a, Point b);
    }
}
