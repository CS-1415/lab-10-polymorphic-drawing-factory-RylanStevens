using System;
using System.Data.Common;

namespace Lab10DrawingApp
{
    public class CircleFactory : IGraphic2DFactory
    {
        public string Name => "Circle";

        public IGraphic2D Create()
        {
            Console.Write("Enter X coordinate for the center: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate for the center: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());

            return new Circle(x, y, radius);
        }
    }
}