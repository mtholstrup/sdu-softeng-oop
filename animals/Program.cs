namespace animals;

class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog("Woof");
        Dog dog2 = new Dog("Ruff");
        Dog dog3 = new Dog("Scruff");
        Dog dog4 = new Dog("Tuff");
        Console.WriteLine(dog1.GetName());
        
        dog1.SetBestFriend(dog2);
        dog3.SetBestFriend(dog1);
        
        if (dog3.GetBestFriend() == null) {
            Console.WriteLine($"{dog3.GetName()} has no best friend.");
        } else {
            Console.WriteLine($"{dog3.GetName()}'s best friend is: {dog3.GetBestFriend().GetName()}");
        }
        
        Parrot parrot1 = new Parrot("Flap");
        Parrot parrot2 = new Parrot("Jack");
        Parrot parrot3 = new Parrot("Beak");
        Console.WriteLine(parrot1.GetName());
        parrot1.SetBestFriend(parrot2);

        Animal animal1 = new Animal("Beast");

        foreach(Animal animal in Animal.GetList()) {
            Console.WriteLine(animal.MakeSound());
        }

        dog2.SetBestFriend(parrot1);
        Console.WriteLine(dog1.GetDescription());
        Console.WriteLine(parrot1.GetDescription());
        Console.WriteLine(animal1.GetDescription());
        Console.WriteLine(Animal.GetCountByType(typeof(Dog)));
        Console.WriteLine(Animal.GetCountByType(typeof(Parrot)));
        Console.WriteLine(Animal.GetCount());

        Whale whale1 = new Whale("Splash");

        try {
            whale1.GetDescription();
        } catch (NotImplementedException e) {
            Console.WriteLine("Not implemented yet: " + e.Message);
        }

        foreach(Animal animal in Animal.GetList()) {
            switch (animal) {
                case Dog dog: {
                    Console.WriteLine(dog.RollAround());
                    break;
                } 
                case Parrot parrot: {
                    Console.WriteLine(parrot.BobToMusic());
                    break;
                }
                default: {
                    break;
                }
            }
        }
    }
}
