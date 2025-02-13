namespace Supplement1_P5.Tests;

public class SphereTest
{
    [Fact]
    public void ConstructorValidRadius_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Sphere(5));
        Assert.Null(exception); 
    }

    [Fact]
        public void Constructor_InvalidRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Sphere(0)); 
            Assert.Throws<ArgumentException>(() => new Sphere(-1)); 
        }
}