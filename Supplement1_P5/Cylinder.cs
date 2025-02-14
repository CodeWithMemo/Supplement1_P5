namespace Supplement1_P5;

public class Cylinder : Shape3D{

    private double radius;
    private double height;

    /// <summary>
    /// Initializes a new instance of the Cylinder class with the 
    /// specified radius and height.
    /// </summary>
    /// <param name="radius">The radius of the cylinder.</param>
    /// <param name="height">The height of the cylinder.</param>
    public Cylinder(double radius, double height)
    {
        Validate(radius, height);
        this.radius = radius;
        this.height = height;
    }

    /// <summary>
    /// Validates the radius and height values to ensure both are greater than zero.
    /// </summary>
    /// <param name="radius">The radius of the cylinder to validate.</param>
    /// <param name="height">The height of the cylinder to validate.</param>
    /// <exception cref="ArgumentException">Thrown when either the radius or height is less than or equal to zero.</exception>
     private void Validate(double radius, double height)
    {
        if (radius <= 0 || height <= 0)
        {
            throw new ArgumentException("Both radius and height must be greater than 0.");
        }
    }

    /// <summary>
    /// Calculates the volume of the cylinder
    /// </summary>
    /// <returns>The volume of the cylinder.</returns>
     public override double GetVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height; 
    }

    public override double GetSurfaceArea()
    {
        return 2 * Math.PI * radius * (radius + height); 
    }

    public override string dump()
    {
        return $"Cylinder: Surface Area = {GetSurfaceArea():0.##}, Volume = {GetVolume():0.##}";
    }
}