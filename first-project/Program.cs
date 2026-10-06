namespace first_project;

class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog("Woof");
        Dog dog2 = new Dog("Ruff");
        Dog dog3 = new Dog("Scruff");
        Console.WriteLine(dog1.GetName());

        dog1.SetBestFriend(dog2);
        dog3.SetBestFriend(dog2);
        dog2.SetBestFriend(dog2);
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
    }
}
