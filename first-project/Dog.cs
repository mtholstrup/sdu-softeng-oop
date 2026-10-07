public class Dog : Animal{
    private string _name;
    private Dog _bestfriend;
    private static int _dogCount;
    
    public Dog(string name) : base(name){
        _dogCount++;
    }
}