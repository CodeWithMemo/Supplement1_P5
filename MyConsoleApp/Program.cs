class Shape3D
{
    public string Name { get; }
    public double Width { get; }
    public double Height { get; }
    public double Depth { get; }

    public Shape3D(string name, double width, double height, double depth)
    {
        Name = name;
        Width = width;
        Height = height;
        Depth = depth;
    }

    public void Dump()
    {
        Console.WriteLine($"Shape: {Name}, Width: {Width}, Height: {Height}, Depth: {Depth}");
    }
}