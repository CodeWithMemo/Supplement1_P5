namespace Supplement1_P5;

public class Sphere : Shape3D{

    private double radius;
    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }

     private void Validate(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
    }    
}