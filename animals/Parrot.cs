public class Parrot : Animal {

    public Parrot (string name) : base(name) {
    }

    public override string GetDescription() {
        return $"{base.GetDescription()}. Parrots go flap flap";
    }

    public override string MakeSound() {
        return "Flap Flap";
    }

    public string BobToMusic() {
        return $"{this.GetName()} is bobbing to music";
    }
}