using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 7, 4));
        shapes.Add(new Circle("green", 4));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} --- Area: {String.Format("{0:0.##}", shape.GetArea())} units squared");
        }
    }
}