using System;
using System.Collections.Generic;
using Figures.TwoDimensional;

namespace Figures.Visitors
{
    public class PerimeterVisitor : IVisitor, ICalculator
    {
        public Dictionary<RegularPolygon, double> Results { get; }
        public double LastResult { get; private set; }
        public string OperationName => "Calculating perimeter";

        public PerimeterVisitor()
        {
            Results = new Dictionary<RegularPolygon, double>();
        }
        
        public void Visit(EquilateralTriangle equilateralTriangle)
        {
            if (!Results.TryGetValue(equilateralTriangle, out var lastResult))
            {
                lastResult = 3 * equilateralTriangle.SideLength;
                Results.Add(equilateralTriangle, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of equilateral triangle with side {equilateralTriangle.SideLength} is {lastResult}");
        }

        public void Visit(Square square)
        {
            if (!Results.TryGetValue(square, out var lastResult))
            {
                lastResult = 4 * square.SideLength;
                Results.Add(square, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of square with side {square.SideLength} is {lastResult}");
        }

        public void Visit(Pentagon pentagon)
        {
            if (!Results.TryGetValue(pentagon, out var lastResult))
            {
                lastResult = 5 * pentagon.SideLength;
                Results.Add(pentagon, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of pentagon with side {pentagon.SideLength} is {lastResult}");
        }
    }
}