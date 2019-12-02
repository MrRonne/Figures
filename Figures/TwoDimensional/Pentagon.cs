namespace Figures.TwoDimensional
{
    public class Pentagon : RegularPolygon
    {
        public Pentagon(uint sideLength) : base(sideLength) { }

        public override string Name => "Pentagon";

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}