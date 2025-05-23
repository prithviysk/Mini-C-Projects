namespace ShapeCalc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------Shape Calculator------");
        
        Circle circle = new Circle("Blue", 5.0);
        Rectangle rectangle = new Rectangle("Green", 3.0, 6.0);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(rectangle);
        
        Console.WriteLine("Shapes in the list: ");

        foreach (Shape shape in shapes)
        {
            shape.DisplayInfo();
            Console.WriteLine($"Area: {shape.CalculateArea()}");
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        }
    }
}