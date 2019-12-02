namespace Figures.TwoDimensional
{
    public abstract class RegularPolygon
    {
        public uint SideLength;

        protected RegularPolygon(uint sideLength)
        {
            SideLength = sideLength;
        }

        public abstract string Name { get; }
        public abstract void Accept(IVisitor visitor);
    }
}