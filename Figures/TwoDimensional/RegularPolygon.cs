namespace Figures.TwoDimensional
{
    public abstract class RegularPolygon
    {
        public readonly uint SideLength;

        protected RegularPolygon(uint sideLength)
        {
            SideLength = sideLength;
        }

        public abstract uint AnglesCount { get; }
        public abstract void Accept(IVisitor visitor);
        
        public override bool Equals(object obj)
        {
            return obj != null &&
                   obj is RegularPolygon regularPolygon &&
                   AnglesCount == regularPolygon.AnglesCount &&
                   SideLength == regularPolygon.SideLength;
        }

        public override int GetHashCode()
        {
            return (int)(AnglesCount ^ SideLength);
        }
    }
}