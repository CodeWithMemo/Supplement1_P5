namespace ShapeContainer;

public class Shape3D
{
    public string Name { get; set; }
    
    public Shape3D(string name)
    {
        Name = name;
    }
}

public class ShapeContainer
{
     private List<Shape3D> shapes = new List<Shape3D>();

    public void Create(Shape3D shape)
    {
        if (shape == null)
        {
            throw new ArgumentNullException(nameof(shape), "Shape cannot be null.");
        }
        shapes.Add(shape);
    }
}
