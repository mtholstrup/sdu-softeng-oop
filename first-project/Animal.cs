public class Animal {
    private string _name;
    private Animal _bestfriend;

    public Animal(string name){
        Console.WriteLine("Animal succesfully instantiated");
        this._name = name;
    }

    public string GetName() {
        return _name;
    }

    public Animal GetBestFriend() {
        return this._bestfriend;
    }

    public void SetBestFriend(Animal friend) {
        if (this == friend || this._name == friend.GetName()) {
            Console.WriteLine("These animals can't be friends");
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