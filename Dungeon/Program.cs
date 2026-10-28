namespace Dungeon;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Room hall = new Room("Hall", "In the large hall, where the fireplace roars");
        Room library = new Room("Library", "In a dusty library");
        Room armory = new Room("Armory", "Armor and weapons hang from the walls");
        Room crypt = new Room("Crypt", "In the crypt, a rat scatter across the floor");
        Room cellar = new Room("Cellar", "In a dirty cellar with moldy food on shelves");
        Room lair = new Room("Lair", "In the lair you feel an ominous precense");
        Room treasury = new Room("Treasury", "In the treasury chests fills the room");
        
        library.SetExit("South", hall);
        library.SetExit("East", crypt);
        hall.SetExit("North", library);
        hall.SetExit("East", armory);
        hall.SetExit("South", cellar);
        crypt.SetExit("West", library);
        crypt.SetExit("South", armory);
        crypt.SetExit("Down", treasury);
        armory.SetExit("North", crypt);
        armory.SetExit("West", hall);
        cellar.SetExit("North", hall);
        cellar.SetExit("Down", lair);
        treasury.SetExit("Up", crypt);

        Hero hero = new Hero("Dave", hall);
        hero.Move("North");
        Console.WriteLine(hero.GetCurrentRoom().GetLongDescription());
        hero.Move("East");
        Console.WriteLine(hero.GetCurrentRoom().GetLongDescription());
        hero.Move("South");
        Console.WriteLine(hero.GetCurrentRoom().GetLongDescription());
        hero.Move("West");
        Console.WriteLine(hero.GetCurrentRoom().GetLongDescription());

        Console.WriteLine(Room.GetCount());
    }
}
