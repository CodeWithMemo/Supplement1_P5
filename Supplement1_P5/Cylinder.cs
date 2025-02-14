namespace Supplement1_P5;

public class Cylinder : Shape3D{

    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        Validate(radius, height);
        this.radius = radius;
        this.height = height;
    }
}