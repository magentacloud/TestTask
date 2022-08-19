namespace ShapeHierarchy
{
    public abstract class CurveLineFigure : FlatShape
    {
        private Point center;
        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

    }
}
