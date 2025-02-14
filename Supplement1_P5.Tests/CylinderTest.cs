namespace Supplement1_P5.Tests;

public class CylindeTest
{
    [Fact]
    public void ConstructorValidRadiusAndHeight_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Cylinder(5, 10));
        Assert.Null(exception);
    }

    [Fact]
        public void Constructor_InvalidRadiusOrHeight_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(5, 0)); 
            Assert.Throws<ArgumentException>(() => new Cylinder(-1, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(5, -1)); 
        }

    [Fact]
        public void GetVolumeCorrectCalculation()
        {
            var cylinder = new Cylinder(3, 7);
            Assert.Equal(Math.PI * Math.Pow(3, 2) * 7, cylinder.GetVolume(), 2); 
        }
}