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

    [Fact]
        public void CreateShouldThrowArgumentNullException_WhenShapeIsNull()
        {
            
            var container = new ShapeContainer();

            
            var exception = Assert.Throws<ArgumentNullException>(() => container.Create(null));
            Assert.Equal("shape", exception.ParamName); 
        }

        [Fact]
        public void GetShouldReturnCorrectShapeWhenIndexIsValid()
        {
           
            var container = new ShapeContainer();
            var shape = new Shape3D("Cube");
            container.Create(shape);

            var retrievedShape = container.Get(0);

            Assert.Equal("Cube", retrievedShape.Name);
        }

        [Fact]
        public void GetShouldThrowArgumentOutOfRangeExceptionWhenIndexIsInvalid()
        {
            
            var container = new ShapeContainer();

            
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0)); 
            Assert.Equal("index", exception.ParamName); 
        }

        [Fact]
        public void Delete_ShouldRemoveShape_WhenIndexIsValid()
        {
            var container = new ShapeContainer();
            var shape1 = new Shape3D("Sphere");
            var shape2 = new Shape3D("Cube");
            container.Create(shape1);
            container.Create(shape2);

            container.Delete(0);

            Assert.Single(container.shapes);
            Assert.Equal("Cube", container.Get(0).Name);
        }

        [Fact]
        public void DeleteShouldThrowArgumentOutOfRangeExceptionWhenIndexIsInvalid()
        {
            var container = new ShapeContainer();
            var shape = new Shape3D("Sphere");
            container.Create(shape);

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => container.Delete(1));
            Assert.Equal("index", exception.ParamName); 
        }

          [Fact]
        public void CreateShouldHandleMultipleShapes()
        {
            var container = new ShapeContainer();
            var shape1 = new Shape3D("Sphere");
            var shape2 = new Shape3D("Cube");
            var shape3 = new Shape3D("Pyramid");

            container.Create(shape1);
            container.Create(shape2);
            container.Create(shape3);

            Assert.Equal(3, container.shapes.Count);
            Assert.Equal("Sphere", container.Get(0).Name);
            Assert.Equal("Cube", container.Get(1).Name);
            Assert.Equal("Pyramid", container.Get(2).Name);
        }
    }