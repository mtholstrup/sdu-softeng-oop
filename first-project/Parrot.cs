public class Parrot {
    private string _name;
    private Parrot _bestfriend;

    public Parrot (string name) {
        Console.WriteLine("Parrot succesfully instantiated");
        this._name = name;
    }

    public string GetName() {
        return _name;
    }

    public Parrot GetBestFriend() {
        return this._bestfriend;
    }

    public void SetBestFriend(Parrot friend) {
        if (this == friend || this._name == friend.GetName()) {
            Console.WriteLine("These parrots can't be friends");
            return;
        }
        
        if (this.GetBestFriend() == null) {
            this._bestfriend = friend;
            Console.WriteLine($"{friend.GetName()} is now {this._name}'s best friend");
        } else {
            Console.WriteLine($"{this._name} already has a best friend");
        }
    }
}