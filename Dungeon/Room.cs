public class Room {
    private string _name;
    private string _description;
    private Room? _northExit, _eastExit, _southExit, _westExit;

    public Room (string name, string description) {
        this._name = name;
        this._description = description;
    }

    public string GetName() { return this._name; }
    public string GetDescription() { return this._description; }

    public void SetExits(Room? north, Room? east, Room? south, Room? west) {
        this._northExit = north;
        this._eastExit = east;
        this._southExit = south;
        this._westExit = west;
    }

    public Room? GetNeighbour(string direction) {
        switch(direction) {
            case "north":
                return this._northExit;
            case "east":
                return this._eastExit;
            case "west":
                return this._westExit;
            case "south":
                return this._southExit;
            default:
                throw new Exception();
        }
    }
}