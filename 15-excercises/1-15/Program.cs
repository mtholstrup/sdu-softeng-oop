namespace _13_excercises;

class Program
{
    static void Main(string[] args)
    {
        FoodItem apple = new FoodItem("apple", 7.99, new DateTime(2026, 10, 7, 12, 30, 00));
        Console.WriteLine(apple);

        NonFoodItem chair = new NonFoodItem("chair", 20.99, new string[]{"wheels", "seat", "pillow"});
        Console.WriteLine(chair);

        List<FoodItem> netto = new List<FoodItem>();

        List<Item> items = new List<Item>();

        for(int i = 0; i < 10; i++) {
            netto.Add(new FoodItem("banan"+i, 2.49, new DateTime(2026, 10, 10)));
            items.Add(new FoodItem("banan"+i, 2.49, new DateTime(2026, 10, 10)));
        }

        foreach(FoodItem food in netto) {
            Console.WriteLine(food);
        }

        NonFoodItem[] bolia = new NonFoodItem[10];
        for(int i = 0; i < bolia.Length; i++) {
            bolia[i] = new NonFoodItem("bed"+i, 199.99, new string[]{"Pillow", "Duvet", "Blanket", "Matress"});
            items.Add(new NonFoodItem("bed"+i, 199.99, new string[]{"Pillow", "Duvet", "Blanket", "Matress"}));
        }

        foreach(NonFoodItem bed in bolia) {
            Console.WriteLine(bed);
        }

        Inventory inventory = new Inventory(items);

        inventory.PrintInventory();
        Console.WriteLine(inventory.GetInventoryValue());

    }
}
