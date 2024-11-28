using System;
namespace Lab10DrawingApp
{
    public class RectangleFactory : IGraphic2DFactory
    {
        public string Name => "Rectangle";
        public IGraphic2D Create()
        {
            Console.Write("Enter X coordinate for the top left corner: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate for the top left corner: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            return new Rectangle(x, y, width, height);
        }
    }
}