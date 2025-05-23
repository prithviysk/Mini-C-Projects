namespace ShapeCalc;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Radius * Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return Math.Round(2 * Math.PI * Radius,2);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Shape Type: Circle");
        Console.WriteLine($"Radius: {Radius}");
    }
}