
public class NonFoodItem : Item {
    private string[] _materials;

    // Constructor
    public NonFoodItem(string name, double price, string[] materials) : base(name, price){
        _materials = materials;
    }

    public string[] GetMaterials() {
        return _materials;
    }

    public override string ToString() {
        string m = String.Join(", ", GetMaterials());
        return $"Name: {this.GetName()}, Price: {this.GetPrice()}$, Materials: {m}"; 
    }
}