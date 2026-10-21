public class Timing {
    public static double initialValue = 1.0000001;
    
    public static double Fun (double x, double y) {
        if (y<=1) {
            return x;
        } else {
            return Fun(x,y-1) * Fun(x,y-1);
        }
    }

    
}