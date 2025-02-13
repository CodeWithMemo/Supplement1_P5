namespace Supplement1_P5.Tests;

public class SphereTest
{
    [Fact]
    public void ConstructorValidRadius_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Sphere(5));
        Assert.Null(exception); 
    }
}