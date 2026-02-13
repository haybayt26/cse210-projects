using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square _square = new Square("Pink", 6);
        Rectangle _rectangle = new Rectangle("Blue", 2, 3);
        Circle _cirlce = new Circle("Yellow", 5);
        _shapes.Add(_square);
        _shapes.Add(_rectangle);
        _shapes.Add(_cirlce);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"\nColor: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}\n");
        }

    }
}