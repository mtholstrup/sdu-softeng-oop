namespace _1_14;

class Program
{
    static void Main(string[] args)
    {
        Kitten[] kittens = new Kitten[10];
        Random r = new Random();
        for (int i = 0; i<10; i++) {
            kittens[i] = new Kitten(r.Next(1,100));
            Console.WriteLine(Kitten.count);
        }

        foreach(Kitten kitten in kittens) {
            Console.WriteLine(kitten.Cuteness);
        }
    }
}
