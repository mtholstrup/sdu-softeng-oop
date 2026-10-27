namespace Dungeon;

class Program
{
    static void Main(string[] args)
    {
        Room hall = new Room("Hall", "In the large hall, where the fireplace roars");
        Room library = new Room("Library", "In a dusty library");
        Room armory = new Room("Armory", "Armor and weapons hang from the walls");
        Room crypt = new Room("Crypt", "In the crypt, a rat scatter across the floor");
        Room cellar = new Room("Cellar", "In a dirty cellar with moldy food on shelves");

        library.SetExits(null, crypt, hall, null);
        hall.SetExits(library, armory, cellar, null);
        crypt.SetExits(null, null, armory, library);
        armory.SetExits(crypt, null, null, hall);
        cellar.SetExits(hall, null, null, null);

        
        Console.WriteLine(hall.GetDescription());
        Console.WriteLine(library.GetDescription());
    }
}
