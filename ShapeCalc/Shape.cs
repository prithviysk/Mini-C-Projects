namespace ShapeCalc;

public abstract class Shape
{
    public string Color { get; set; }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"-------Shape Info-------");
        Console.WriteLine($"Color: {Color}");
    }

    public Shape(string color)
    {
        Color = color;
    }
}