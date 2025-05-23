namespace AnimalSound;

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();
        
        Dog bubby = new Dog("Pug", "Bubby", 2);
        Dog stewie = new Dog("Husky", "Stewie", 4);
        Cat violet = new Cat(true, "Violet", 3);
        Cat alhilal = new Cat(true, "Al hilal", 2);
        Bird perry = new Bird("Perry", 1, 0.5, 100); 
        Fish nemo = new Fish("Nemo", 0, 500,"Orange"); 
        Duck daffy = new Duck("Daffy", 4, 200, 20);
        
        zoo.AddAnimal(bubby);
        zoo.AddAnimal(stewie);
        zoo.AddAnimal(violet);
        zoo.AddAnimal(alhilal);
        zoo.AddAnimal(perry);
        zoo.AddAnimal(nemo);
        zoo.AddAnimal(daffy);
        
        zoo.MakeAllAnimalSounds();
        zoo.FeedAllAnimals();
        zoo.MakeAllAnimalsFly();
        zoo.MakeAllAnimalsSwim();
    }
}