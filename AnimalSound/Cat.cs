namespace AnimalSound;

public class Cat : Animal
{
    public bool IsIndoorCat { get; set; }

    public Cat(bool isIndoorCat, string name, int age) : base(name, age)
    {
        IsIndoorCat = isIndoorCat;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Meow!!!");
    }
}