namespace ShapeContainer.Tests;

public class ShapeContainerTests
{
    [Fact]
    public void CreateShouldAddShapeToContainer()
    {
        var container = new ShapeContainer();
        var shape = new Shape3D("Sphere");

        container.Create(shape);

        Assert.Equal(1, container.shapes.Count);
        Assert.Equal("Sphere", container.Get(0).Name);
    }
}