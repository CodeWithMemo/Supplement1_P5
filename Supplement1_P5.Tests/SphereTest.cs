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

    [Fact]
        public void GetSurfaceArea_CorrectCalculation()
        {
            // Arrange
            var sphere = new Sphere(4);

            // Assert
            Assert.Equal(4 * Math.PI * Math.Pow(4, 2), sphere.GetSurfaceArea(), 2); // Surface Area calculation
        }

        [Fact]
        public void Dump_ReturnsCorrectString()
        {
            // Arrange
            var sphere = new Sphere(2);
            string expected = "Sphere: Surface Area = 50.27, Volume = 33.51";

            // Act & Assert
            Assert.Equal(expected, sphere.dump()); // Expected output for Dump
        }
}