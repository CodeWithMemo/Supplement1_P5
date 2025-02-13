namespace Supplement1_P5;

public class Sphere : Shape3D{

    private double radius;
    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }
    
}