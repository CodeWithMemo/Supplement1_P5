namespace Supplement1_P5.Tests;

public class CubeTest
{
    [Fact]
    public void ConstructorValidSideLength_DoesNotThrow(){
        var exception = Record.Exception(() => new Cube(5));
        Assert.Null(exception);
    }
   
}