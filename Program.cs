using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Lab10DrawingApp;

namespace Lab10DrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the drawing app");
            Console.WriteLine("You can create, view or remove shapes of your drawing");
            List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>
            {
                new CircleFactory(),
                new RectangleFactory()
            };

            List<IGraphic2D> builtShapes = new List<IGraphic2D>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Display Drawing");
                Console.WriteLine("2. Add Graphic");
                Console.WriteLine("3. Remove Graphic");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        Console.Clear();
                        AbstractGraphic2D.Display(builtShapes);
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Available Shape tools");
                        for (int i = 0; i < availableShapeTypes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {availableShapeTypes[i].Name}"); 
                          
                        }
                        Console.Write("Enter the number of the shape to add: ");
                        if (int.TryParse(Console.ReadLine(), out int factoryIndex) && factoryIndex > 0 && factoryIndex <= availableShapeTypes.Count)
                        {
                            IGraphic2D newShape = availableShapeTypes[factoryIndex - 1].Create();
                            builtShapes.Add(newShape);
                            Console.WriteLine("Shape added! Press entert to continue...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, try next time.");

                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Current Drawing:");
                        for (int i = 0; i < builtShapes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {builtShapes[i]}");
                        }

                        Console.Write("Enter the number of the shape to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex) && removeIndex > 0 && removeIndex <= builtShapes.Count)
                        {
                            builtShapes.RemoveAt(removeIndex - 1);
                            Console.WriteLine("Shape removed! Press Enter to continue");
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Exciting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. press enter to try again");
                        Console.ReadLine();
                        break;

                    

                }
            }
        }
    }
}