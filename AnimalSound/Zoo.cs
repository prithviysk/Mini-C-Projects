namespace AnimalSound;

public class Zoo
{
    private List<Animal> _animals = new List<Animal>();

    public Zoo()
    {
        Console.WriteLine("Zoo created");
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        Console.WriteLine($"{animal.Name} added to Zoo");
    }

    public void MakeAllAnimalSounds()
    {
        Console.WriteLine("\n--- All Animals Making Sounds ---");
        foreach (Animal animal in _animals)
        {
            animal.MakeSound();
        }
    }
    
    public void FeedAllAnimals()
    {
        Console.WriteLine("\n--- All Animals Eating ---");
        foreach (Animal animal in _animals)
        {
            animal.Eat();
        }
    }

    public void MakeAllAnimalsFly()
    {
        Console.WriteLine("\n--- All Flyable Animals Taking Flight ---");
        foreach (Animal animal in _animals)
        {
            if (animal is IFlyable flyableAnimal)
            {
                flyableAnimal.Fly();
                Console.WriteLine($"Flying at {flyableAnimal.MaxFlightAltitude}");
            }
            else
            {
                Console.WriteLine($"{animal.Name} cannot fly.");
            }
        }
    }
    
    public void MakeAllAnimalsSwim()
    {
        Console.WriteLine("\n--- All Swimmable Animals Swimming ---");
        foreach (Animal animal in _animals)
        {
            if (animal is ISwimmable swimmableAnimal) 
            {
                swimmableAnimal.Swim();
                Console.WriteLine($"  Max Dive Depth: {swimmableAnimal.MaxDiveDepth} feet.");
            }
            else
            {
                Console.WriteLine($"{animal.Name} cannot swim.");
            }
        }
    }
}