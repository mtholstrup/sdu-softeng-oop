public class Item{
    private string _name;
    private double _price;

    public Item (string name, double price) {
        _name = name;
        _price = price;
    }

    public string GetName() {
        return this._name;
    }

    public double GetPrice() {
        return this._price;
    }
}