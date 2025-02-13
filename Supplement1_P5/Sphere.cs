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

     public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3); // Volume = 4/3 * π * r^3
    } 

    public override double GetSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2); // Surface Area = 4 * π * r^2
    }
}