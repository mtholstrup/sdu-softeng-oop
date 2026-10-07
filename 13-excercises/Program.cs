namespace _13_excercises;

class Program
{
    static void Main(string[] args)
    {
        FoodItem apple = new FoodItem("apple", 7.99, new DateTime(2026, 10, 7, 12, 30, 00));
        Console.WriteLine(apple);

        NonFoodItem chair = new NonFoodItem("chair", 20.99, new string[]{"wheels", "seat", "pillow"});
        Console.WriteLine(chair);

        FoodItem[] netto = new FoodItem[10];

        for(int i = 0; i < netto.Length; i++) {
            netto[i] = new FoodItem("banan"+i, 2.49, new DateTime(2026, 10, 10));
        }

        foreach(FoodItem food in netto) {
            Console.WriteLine(food);
        }

        NonFoodItem[] bolia = new NonFoodItem[10];
        for(int i = 0; i < bolia.Length; i++) {
            bolia[i] = new NonFoodItem("bed"+i, 199.99, new string[]{"Pillow", "Duvet", "Blanket", "Matress"});
        }

        foreach(NonFoodItem bed in bolia) {
            Console.WriteLine(bed);
        }
    }
}
