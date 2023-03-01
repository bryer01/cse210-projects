using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape square = new Square("Red", 5);
        Shape rectangle = new Rectangle("Blue", 3, 4);
        Shape circle = new Circle("Green", 2);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: {0}, Area: {1}", shape.GetColor(), shape.GetArea());
        }

        Console.ReadLine();
    }
}
