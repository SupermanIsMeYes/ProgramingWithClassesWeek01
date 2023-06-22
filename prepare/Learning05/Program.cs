using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape01 = new Square("Red", 3);
        shapes.Add(shape01);

        Rectangle shape02 = new Rectangle("Blue", 4, 5);
        shapes.Add(shape02);

        Circle shape03 = new Circle("Green", 6);
        shapes.Add(shape03);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}