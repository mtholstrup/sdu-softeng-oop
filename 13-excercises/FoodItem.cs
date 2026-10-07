public class FoodItem : Item {
    private DateTime expiresAt;

    //constructor
    public FoodItem(string name, double price, DateTime expiry) : base(name, price)  {
        expiresAt = expiry;
    }

    //DateTime Getter
    public DateTime GetExpiresAt() {
        return expiresAt;
    }

    public override string ToString() {
        return ($"Name: {this.GetName()}, Price: {this.GetPrice()}$, Expires at {this.GetExpiresAt()}");
    }
}