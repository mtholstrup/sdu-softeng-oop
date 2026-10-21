public class Circle {
    private double x, y;
    private double d;

    public Circle (double x, double y, double diameter) {
        this.x = x;
        this.y = y;
        this.d = diameter;
    }

    public double GetX() {
        return this.x;
    }

    public double GetY() {
        return this.y;
    }
    
    public double GetD() {
        return this.d;
    }

    public void SetX (double x) {
        this.x = x;
    }

    public void SetY (double y) {
        this.y = y;
    }
    
    public void SetD (double d) {
        this.d = d;
    }
}