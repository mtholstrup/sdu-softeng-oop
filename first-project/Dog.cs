public class Dog {
    private string _name;
    private Dog _bestfriend;

    public Dog(string name){
        Console.WriteLine("Dog succesfully instantiated");
        this._name = name;
    }

    public string GetName() {
        return _name;
    }

    public Dog GetBestFriend() {
        return this._bestfriend;
    }

    public void SetBestFriend(Dog friend) {
        if (this == friend || this._name == friend.GetName()) {
            Console.WriteLine("These dogs can't be friends");
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