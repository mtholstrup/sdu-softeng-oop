namespace _5_14;

class Program
{
    static void Main(string[] args)
    {
        /* 
        This programs main method creates an object from the class circle.
        This new circle object has the variable name c.
        In the constructor we give 3 values. x-value, y-value and a radius.
        The values are printed.
        We then multiplicate the c.r value with 1.37 and plus the c.x value with 0.65
        It is then printed again

        To change to diameter i had to change c.r to c.d and change the constructor
        */

        Circle c = new Circle(1.24, 1.83, 12.7);
        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.d);

        c.d *= 1.37;
        c.x += 0.65;

        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.d);
    }
}
