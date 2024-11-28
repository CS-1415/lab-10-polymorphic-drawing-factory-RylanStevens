using System;
using System.Collections.Generic;
using Lab10DrawingApp;

namespace Lab10DrawingApp
{
    public abstract class AbstractGraphic2D : IGraphic2D
    {
        public abstract void Display();
        public static void Display(List<IGraphic2D> shapes)
        {
            Console.Clear();
            foreach (IGraphic2D shape in shapes)
            {
                shape.Display();
            }
        }
    }
}