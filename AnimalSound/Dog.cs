namespace AnimalSound;

public class Dog: Animal
{
    public string Breed { get; set; }

    public Dog(string breed, string name, int age) : base(name, age)
    {
        Breed = breed;
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine($"{Name} is munching on something");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Woof Woof");
    }
}