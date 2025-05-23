namespace ShapeCalc;

public class Rectangle:Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(string color, double height, double width): base(color)
    {
        Height = height;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Height * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2*(Height + Width);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Shape Type: Rectangle");
        Console.WriteLine($"Height: {Height}, Width: {Width}");
    }
}