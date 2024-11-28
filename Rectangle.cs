using System;
namespace Lab10DrawingApp
{
    public class Rectangle : AbstractGraphic2D
    {
        public int X { get; }
        public int Y { get; }
        public int Width { get; }  
        public int Height { get; }  

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle at ({X}, {Y}) with width {Width} and height {Height}");
        }
        public override string ToString() => $"Rectangle at ({X}, {Y}) with width {Width} and height {Height}";
    }
}