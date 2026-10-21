public class Coordinate {
    private double x,y;

    public Coordinate (double x, double y) {
        this.x = x;
        this.y = y;
    }

    public double GetX() {
        return this.x;
    }

    public double GetY() {
        return this.y;
    }

    public void SetX (double x) {
        this.x = x;
    }

    public void SetY (double y) {
        this.y = y;
    }
}