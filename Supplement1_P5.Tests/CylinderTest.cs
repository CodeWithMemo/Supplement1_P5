namespace Supplement1_P5.Tests;

public class CylindeTest
{
    [Fact]
    public void ConstructorValidRadiusAndHeight_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Cylinder(5, 10));
        Assert.Null(exception);
    }
}