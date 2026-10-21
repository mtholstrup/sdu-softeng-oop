public class Animal {
    private string _name;
    private Animal _bestfriend;
    private static List<Animal> _animalList = new List<Animal>();

    public Animal(string name){
        _animalList.Add(this);
        Console.WriteLine($"{this.GetType().Name} succesfully instantiated");
        this._name = name;
    }

    public static int GetCountByType(Type animalType) {
        int animalCount = 0;
        foreach(Animal animal in _animalList) {
            if(animal.GetType() == animalType) {
                animalCount++;
            }
        }
        return animalCount;
    }
    
    public static List<Animal> GetList() {
        return _animalList;
    }

    public static int GetCount() {
        return _animalList.Count;
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
    
    public override string ToString() {
        string friend;
        if (this._bestfriend != null) {
            friend = this._bestfriend.GetName();
        } else {
            friend = "No friend";
        }
        return $"Name: {this.GetName()} Bestfriend: {friend}";
    }

    public virtual string GetDescription() {
        return "Animals are cool";
    }

    public virtual string MakeSound() {
        return "Stomp Stomp";
    }
}