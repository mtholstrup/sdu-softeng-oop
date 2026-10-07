public class FoodItem : Item {
    private string _name;
    private double _price;
    private DateTime expiresAt;

    public FoodItem(string name, double price, DateTime expiry) : base(name, price)  {
        _name = name;
        _price = price;
        expiresAt = expiry;
        Console.WriteLine("fooditem");
    }

    public DateTime GetExpiresAt() {
        return expiresAt;
    }

    public override string ToString() {
        return ($"Name: {this.GetName()}, Price: {this.GetPrice()}$, Expires at {this.GetExpiresAt()}");
    }
}
        
