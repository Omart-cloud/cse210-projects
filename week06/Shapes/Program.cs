using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create shape instances
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Circle circle = new Circle("Green", 2.5);

        // Create a list of shapes
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Iterate through the list and display color and area for each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea():F2}");
            Console.WriteLine("--------------------");
        }
    }
}