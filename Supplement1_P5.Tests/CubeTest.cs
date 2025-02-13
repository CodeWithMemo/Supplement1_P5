namespace Supplement1_P5.Tests;

public class CubeTest
{
    [Fact]
    public void ConstructorValidSideLength_DoesNotThrow(){
        var exception = Record.Exception(() => new Cube(5));
        Assert.Null(exception);
    }

    [Fact]
    public void Constructor_InvalidSideLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Cube(0));
        Assert.Throws<ArgumentException>(() => new Cube(-1));
    }

    [Fact]
    public void GetVolumeCorrectCalculation()
    {
        var cube = new Cube(3);
        Assert.Equal(27, cube.GetVolume());
    }

    [Fact]
    public void GetSurfaceArea_CorrectCalculation()
    {
        var cube = new Cube(4);
        Assert.Equal(96, cube.GetSurfaceArea());
    }
   
}