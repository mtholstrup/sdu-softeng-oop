namespace first_project;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Woof";
        Console.WriteLine(dog.Name);
        
        Parrot parrot = new Parrot();
        parrot.Name = "Flap";
        Console.WriteLine(parrot.Name);
    }
}
