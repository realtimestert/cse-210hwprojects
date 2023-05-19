using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Orange", 3);
        shapes.Add(s1);

        Circle c1 = new Circle("Pink", 4);
        shapes.Add(c1);

        Reactangle r1 = new Reactangle("Beige", 6,7);
        shapes.Add(r1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}