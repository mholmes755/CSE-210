using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Thread.Sleep(2000);

        Square _square = new Square("red", 2.5);
        Rectangle _rectangle = new Rectangle("white", 3, 6.5);
        Circle _circle = new Circle("blue", 5.4);

        // double squareArea = _square.GetArea();
        // string squareColor = _square.GetColor();


        // double rectangleArea = _rectangle.GetArea();
        // string rectangleColor = _rectangle.GetColor();


        // double circleArea = _circle.GetArea();
        // string circleColor = _circle.GetColor();




        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(_square);
        _shapes.Add(_rectangle);
        _shapes.Add(_circle);

        foreach (Shape s in _shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"This is a {color} shape with an area of {area}");

        }
    }
}