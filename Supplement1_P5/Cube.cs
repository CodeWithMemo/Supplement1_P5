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
}