public class Dog : Animal{
    
    public Dog(string name) : base(name){
    }

    public override string GetDescription() {
        return $"{base.GetDescription()}. Dogs go bark bark";
    }

    public sealed override string MakeSound() {
        return "Bark Bark";
    }

    public string RollAround() {
        return $"{this.GetName()} is rolling around";
    }
}