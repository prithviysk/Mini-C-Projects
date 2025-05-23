namespace AnimalSound;

public class Duck:Animal,IFlyable,ISwimmable
{
    public int MaxDiveDepth { get; }
    public int MaxFlightAltitude { get; }

    public Duck(string name, int age, int maxDiveDepth, int maxFlightAltitude):base(name,age)
    {
        MaxDiveDepth = maxDiveDepth;
        MaxFlightAltitude = maxFlightAltitude;
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} duck Swims at a depth {MaxDiveDepth}");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} duck flies at a depth {MaxFlightAltitude}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (a duck) says: Quack! Quack!");
    }
}