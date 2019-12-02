using Figures.TwoDimensional;

namespace Figures
{
    public interface IVisitor
    {
        string OperationName { get; }
        void Visit(Triangle triangle);
        void Visit(Rectangle rectangle);
        void Visit(Pentagon pentagon);
    }
}