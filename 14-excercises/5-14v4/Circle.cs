public class Circle {
    private Coordinate c;
    private double d;

    public Circle (double x, double y, double diameter) {
        this.c = new Coordinate (x,y);
        this.d = diameter;
    }

    public double GetD() {
        return this.d;
    }

    public void SetD (double d) {
        this.d = d;
    }

    public double GetX() {
        return c.GetX();
    }

    public double GetY() {
        return c.GetY();
    }

    public void SetX (double x) {
        c.SetX(x);
    }

    public void SetY (double y) {
        c.SetY(y);
    }
}