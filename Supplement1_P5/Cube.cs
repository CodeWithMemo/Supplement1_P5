namespace Supplement1_P5;

public class Cube : Shape3D{
    private double sideLength;

    public Cube(double sideLength)
    {
        Validate(sideLength);
        this.sideLength = sideLength;
    }
}