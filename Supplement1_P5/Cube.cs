namespace Supplement1_P5;

public class Cube : Shape3D{
    private double sideLength;

/// <summary>
/// Initializes a new instance of the Cube class with the specified side length.
/// </summary>
/// <param name="sideLength">The length of one side of the cube. Must be greater than 0.</param>
    public Cube(double sideLength)
    {
        Validate(sideLength);
        this.sideLength = sideLength;
    }

/// <summary>
/// Validates that the side length is greater than 0.
/// </summary>
/// <param name="sideLength">The length of one side of the cube.</param>
/// <exception cref="ArgumentException">Thrown when the side length is less than or equal to 0.</exception>
     private void Validate(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Side length must be greater than 0.");
        }
    }

/// <summary>
/// Calculates the volume of the cube.
/// </summary>
/// <returns>The volume of the cube.</returns>
    public override double GetVolume()
    {
        return Math.Pow(sideLength, 3); // Volume = side^3
    }

/// <summary>
/// Calculates the surface area of the cube.
/// </summary>
/// <returns>The surface area of the cube.</returns>
    public override double GetSurfaceArea()
    {
        return 6 * Math.Pow(sideLength, 2); // Surface Area = 6 * side^2
    }

/// <summary>
/// Returns a string representation of the cube, including its surface area and volume.
/// </summary>
/// <returns>A string containing the surface area and volume of the cube.</returns>
    public override string dump()
    {
        return $"Cube: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }

}