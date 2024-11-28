using System;
using System.Dynamic;

namespace Lab10DrawingApp
{
    public class Circle : AbstractGraphic2D
    {
        public int X { get; }
        public int Y { get; }
        public int Radius { get; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Circle at ({X}, {Y}) with radius {Radius}");
        }

        public override string ToString() => $"Circle at ({X}, {Y}) with radius {Radius}";
    }
}