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

    [Fact]
        public void GetSurfaceArea_CorrectCalculation()
        {
            var cylinder = new Cylinder(4, 6);
            Assert.Equal(2 * Math.PI * 4 * (4 + 6), cylinder.GetSurfaceArea(), 2); 
        }

    [Fact]
        public void Dump_ReturnsCorrectString()
        {
            var cylinder = new Cylinder(2, 5);
            string expected = "Cylinder: Surface Area = 87.96, Volume = 62.83";

            Assert.Equal(expected, cylinder.Dump()); 
        }
}