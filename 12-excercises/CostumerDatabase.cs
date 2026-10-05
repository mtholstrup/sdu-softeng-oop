public class CustomerDatabase {
    Customer[] customers;

    public CustomerDatabase() {
        customers = new Customer[10];
    }

    public void addCustomer (Customer customer) {
        customers[customer.Id - 1] = customer;
    }

    public void removeCustomer (int value) {
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] != null && customers[i].Id == value) {
                Console.WriteLine($"{customers[i].Name} has been removed");
                customers[i] = null;
            } else {
                continue;
            }
        }
    }

    public Customer[] returnCustomers () {
        return(Customer[])customers.Clone();
    }

    public void printCustomers() {
        foreach (Customer customer in customers) {
            if (customer==null) continue;
            Console.WriteLine(customer.Name);
        }
    }
}