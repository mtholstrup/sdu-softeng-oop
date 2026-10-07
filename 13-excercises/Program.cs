namespace _13_excercises;

class Program
{
    static void Main(string[] args)
    {
        FoodItem apple = new FoodItem("apple", 7.99,new DateTime(2026, 10, 7, 12, 30, 00));
        Console.WriteLine(apple);
    }
}
