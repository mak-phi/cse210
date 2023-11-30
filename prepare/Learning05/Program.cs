using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(8, "blue");
        Circle c1 = new Circle(8, "yellow");
        Rectangle r1 = new Rectangle(8, 4, "red");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");            
        }
    }
}