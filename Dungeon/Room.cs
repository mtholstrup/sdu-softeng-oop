public class Room {
    private string _name;
    private string _description;
    private Dictionary<string, Room> _exits = new Dictionary<string, Room>();
    private static int _roomCount = 0;

    public Room (string name, string description) {
        this._name = name;
        this._description = description;
        _roomCount ++;
    }

    public string GetName() { return this._name; }
    public string GetDescription() { return this._description; }

    public string GetLongDescription() {
        return $"{GetDescription()}. \nUdgange: {GetExitString()} \n";
    }

    private string GetExitString() {
        return string.Join(", ", _exits.Keys);
    }

    public void SetExit(string direction, Room neighbour) {
        _exits[direction] = neighbour;
    }

    public Room? GetNeighbour(string direction) {
        if (_exits.TryGetValue(direction, out Room? neighbour)) {
            return neighbour;
        }
        return null;
    }

    public static int GetCount() {
        return _roomCount;
    }
}