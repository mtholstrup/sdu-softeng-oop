namespace _12_excercises;

class Program
{
    static void Main(string[] args)
    {
        Customer aCustomer = new Customer("Jens", 01, 100);
        Customer bCustomer = new Customer("Lars", 02, 50);
        Customer cCustomer = new Customer("Ole", 03, 200);


        aCustomer.Deposit(150);
        aCustomer.Withdraw(50);
        Console.WriteLine(aCustomer.GetBalance());

        CustomerDatabase data = new CustomerDatabase();
        data.addCustomer(aCustomer);
        data.addCustomer(bCustomer);
        data.addCustomer(cCustomer);

        data.printCustomers();
        data.removeCustomer(02);
        data.printCustomers();
    }
}