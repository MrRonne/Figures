using System;
using Figures.TwoDimensional;
using Figures.Visitors;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var equilateralTriangle = new EquilateralTriangle(1);
            var square = new Square(1);
            var pentagon = new Pentagon(1);

            RegularPolygon[] regularPolygons =
            {
                equilateralTriangle,
                square,
                pentagon,
            };

            var perimeterVisitor = new PerimeterVisitor();
            var areaVisitor = new AreaVisitor();
            var drawVisitor = new DrawVisitor();
            
            foreach (var regularPolygon in regularPolygons)
            {
                Console.WriteLine(areaVisitor.OperationName);
                regularPolygon.Accept(areaVisitor);

                Console.WriteLine(perimeterVisitor.OperationName);
                regularPolygon.Accept(perimeterVisitor);

                //Draw(int x, int y)
                drawVisitor.SetDrawingCoordinates((int)regularPolygon.AnglesCount, (int)regularPolygon.SideLength);
                Console.WriteLine(drawVisitor.OperationName);
                regularPolygon.Accept(drawVisitor);

                Console.WriteLine();

            }

            //GetArea()
            var pentagonArea = areaVisitor.Results[pentagon];
            //Anything(...)
            var squarePerimeter = perimeterVisitor.Results[square];

            Console.WriteLine($"Pentagon area is {pentagonArea}. Last areaVisitor result  is {areaVisitor.LastResult}. They are equals.");
            Console.WriteLine($"Square perimeter is {squarePerimeter}. Last perimeterVisitor result is {perimeterVisitor.LastResult}. They are not equals.");
            Console.WriteLine("This is because pentagon was last regular polygon.");

            Console.ReadKey();
        }
    }
}
