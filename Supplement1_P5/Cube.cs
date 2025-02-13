namespace Supplement1_P5;

public class Cube : Shape3D{
    private double sideLength;

    public Cube(double sideLength)
    {
        Validate(sideLength);
        this.sideLength = sideLength;
    }

     private void Validate(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Side length must be greater than 0.");
        }
    }

    public override double GetVolume()
    {
        return Math.Pow(sideLength, 3); // Volume = side^3
    }

    public override double GetSurfaceArea()
    {
        return 6 * Math.Pow(sideLength, 2); // Surface Area = 6 * side^2
    }

}