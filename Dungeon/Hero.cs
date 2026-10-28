public class Hero {
    private string _name;
    private int _health;
    private Room _currentRoom;
    
    public Hero (string name, Room startRoom) {
        this._name = name;
        this._currentRoom = startRoom;
    }
    
    public string GetName() { return this._name; }
    public int GetHealth() { return this._health; }
    public Room GetCurrentRoom() { return this._currentRoom; }

    public void Move(string direction) {
        Room? next = _currentRoom.GetNeighbour(direction);
        if (next == null) {
            throw new InvalidOperationException($"There is no exit towards {direction}.");
        } 
        this._currentRoom = next;
    }

}