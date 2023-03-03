using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        Rectangle rectangle1 = new Rectangle();
        Circle circle1 = new Circle();

        square1.setColor("blue");
        square1.setSide(15.2);

        rectangle1.setColor("red");
        rectangle1.setWidth(12.5);
        rectangle1.SetLength(9.8);

        circle1.setColor("gray");
        circle1.setRadius(42);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape sha in shapes) 
        {
            Console.WriteLine(sha.getColor());
            Console.WriteLine(sha.getArea());
        }
    }
}