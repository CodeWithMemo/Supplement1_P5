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

    [Fact]
        public void GetVolumeCorrectCalculation()
        {
            var sphere = new Sphere(3);

            Assert.Equal((4.0 / 3.0) * Math.PI * Math.Pow(3, 3), sphere.GetVolume(), 2);
        }

}