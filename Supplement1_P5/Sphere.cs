namespace Supplement1_P5;

public class Sphere : Shape3D{

    private double radius;

    /// <summary>
    /// Initializes a new instance of the Sphereclass with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the sphere.</param>
    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }

    /// <summary>
    /// Validates the radius value to ensure it is greater than zero.
    /// </summary>
    /// <param name="radius">The radius value to validate.</param>
    /// <exception cref="ArgumentException">Thrown when the radius is less than or equal to zero.</exception>
     private void Validate(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
    }   

    /// <summary>
    /// Calculates the volume of the sphere
    /// </summary>
    /// <returns>The volume of the sphere.</returns>
     public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    } 

    /// <summary>
    /// Calculates the surface area of the sphere
    /// </summary>
    /// <returns>The surface area of the sphere.</returns>
    public override double GetSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2); 
    }

    /// <summary>
    /// Returns a string representation of the sphere, including its surface area and volume.
    /// </summary>
    /// <returns>A string describing the surface area and volume of the sphere.</returns>
    public override string dump()
    {
        return $"Sphere: Surface Area = {GetSurfaceArea():0.##}, Volume = {GetVolume():0.##}";
    }
}