using System;
using System.Collections.Generic;
using Figures.TwoDimensional;

namespace Figures.Visitors
{
    public class AreaVisitor : IVisitor, ICalculator
    {
        public Dictionary<RegularPolygon, double> Results { get; }
        public double LastResult { get; private set; }
        public string OperationName => "Calculating area";

        public AreaVisitor()
        {
            Results = new Dictionary<RegularPolygon, double>();
        }
        
        public void Visit(EquilateralTriangle equilateralTriangle)
        {
            if (!Results.TryGetValue(equilateralTriangle, out var lastResult))
            {
                lastResult = (Math.Sqrt(3) / 4) * equilateralTriangle.SideLength * equilateralTriangle.SideLength;
                Results.Add(equilateralTriangle, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of equilateral triangle with side {equilateralTriangle.SideLength} is {lastResult}");
        }

        public void Visit(Square square)
        {
            if (!Results.TryGetValue(square, out var lastResult))
            {
                lastResult = square.SideLength * square.SideLength;
                Results.Add(square, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of square with side {square.SideLength} is {LastResult}");
        }

        public void Visit(Pentagon pentagon)
        {
            if (!Results.TryGetValue(pentagon, out var lastResult))
            {
                lastResult = (5.0 / 4) * pentagon.SideLength * pentagon.SideLength * (1.0 / Math.Tan(Math.PI / 5));
                Results.Add(pentagon, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of pentagon with side {pentagon.SideLength} is {LastResult}");
        }
    }
}