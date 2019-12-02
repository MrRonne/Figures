using Figures.TwoDimensional;

namespace Figures
{
    public interface IVisitor
    {
        string OperationName { get; }
        void Visit(EquilateralTriangle equilateralTriangle);
        void Visit(Square square);
        void Visit(Pentagon pentagon);
    }
}