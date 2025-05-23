namespace AnimalSound;

public class Bird : Animal, IFlyable
{
    public double WingSpan { get; set; }
    public int MaxFlightAltitude { get; }

    public Bird(string name, int age, double wingSpan, int maxFlightAltitude):base(name,age)
    {
        WingSpan = wingSpan;
        MaxFlightAltitude = maxFlightAltitude;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Chirp!!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying at {MaxFlightAltitude}");
    }
}