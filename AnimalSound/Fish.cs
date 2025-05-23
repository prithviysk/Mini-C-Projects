namespace AnimalSound;

public class Fish:Animal,ISwimmable
{
    public int MaxDiveDepth { get; }
    public string ScaleColor { get; set; }

    public Fish(string name, int age, int maxDiveDepth, string scaleColor) : base(name, age)
    {
        MaxDiveDepth = maxDiveDepth;
        ScaleColor = scaleColor;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}Blub Blub");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} Swims at a depth {MaxDiveDepth}");
    }
}