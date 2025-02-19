﻿namespace ShapeContainer;

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

/// <summary>
/// Adds a 3D shape to the collection.
/// </summary>
/// <param name="shape">The 3D shape to be added.</param>
/// <exception cref="ArgumentNullException">Thrown when the provided shape is null.</exception>
    public void Create(Shape3D shape)
    {
        if (shape == null)
        {
            throw new ArgumentNullException(nameof(shape), "Shape cannot be null.");
        }
        shapes.Add(shape);
    }

    public Shape3D Get(int index)
    {
        if (index < 0 || index >= shapes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return shapes[index];
    }

     public void Delete(int index)
    {
        if (index < 0 || index >= shapes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        shapes.RemoveAt(index);
    }
}
