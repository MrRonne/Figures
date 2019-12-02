using System;

namespace Figures.TwoDimensional
{
    public abstract class RegularPolygon
    {
        public readonly double SideLength;

        protected RegularPolygon(double sideLength)
        {
            if (sideLength <= 0)
                throw new ArgumentException("Side length was not positive");
            SideLength = sideLength;
        }

        public abstract uint AnglesCount { get; }
        public abstract void Accept(IVisitor visitor);
        
        public override bool Equals(object obj)
        {
            return obj != null &&
                   obj is RegularPolygon regularPolygon &&
                   AnglesCount == regularPolygon.AnglesCount &&
                   Math.Abs(SideLength - regularPolygon.SideLength) < 1e-10;
        }

        public override int GetHashCode()
        {
            return (int)AnglesCount ^ (int)SideLength*13;
        }
    }
}