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
   
}