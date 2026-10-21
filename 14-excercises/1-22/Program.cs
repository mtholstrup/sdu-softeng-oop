namespace _1_22;

class Program
{
    static void Main(string[] args)
    {
        /*
        for (double i =1; i<32; i++) {
            long t0 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double f = Timing.Fun(Timing.initialValue, i);
            long t1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Console.WriteLine($"Fun({Timing.initialValue}, {i}) = {f} (The calculation took {t1-t0} ms)");
        }
        */
        
        for (long i = 1000; i<=1000000; i*=10) {
            DateTime d = System.DateTimeOffset.FromUnixTimeMilliseconds(i).DateTime;
            Console.WriteLine(d.ToString());
        }
    }
}
