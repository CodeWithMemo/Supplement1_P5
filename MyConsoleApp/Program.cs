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

class ShapeContainer
{
    private List<Shape3D> shapes = new List<Shape3D>();

    public void AddShape(Shape3D shape)
    {
        shapes.Add(shape);
    }

    public Shape3D GetShape(int index)
    {
        if (index >= 0 && index < shapes.Count)
            return shapes[index];
        return null;
    }

    public bool RemoveShape(int index)
    {
        if (index >= 0 && index < shapes.Count)
        {
            shapes.RemoveAt(index);
            return true;
        }
        return false;
    }
}  

class Program
{
    static void Main()
    {
        ShapeContainer container = new ShapeContainer();
        string command;

        Console.WriteLine("Shape Manager - Enter commands (create, get, delete, exit):");
        while (true)
        {
            Console.Write("Command: ");
            command = Console.ReadLine()?.Trim().ToLower();

            if (command == "exit") break;
            else if (command == "create")
            {
                Console.Write("Enter shape name: ");
                string name = Console.ReadLine();
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Enter depth: ");
                double depth = double.Parse(Console.ReadLine());

                Shape3D shape = new Shape3D(name, width, height, depth);
                container.AddShape(shape);
                shape.Dump();
            }
            else if (command == "get")
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());
                Shape3D shape = container.GetShape(index);
                if (shape != null)
                    shape.Dump();
                else
                    Console.WriteLine("Invalid index.");
            }
            else if (command == "delete")
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());
                if (container.RemoveShape(index))
                    Console.WriteLine("Shape deleted successfully.");
                else
                    Console.WriteLine("Invalid index.");
            }
            else
            {
                Console.WriteLine("Unknown command. Available commands: create, get, delete, exit.");
            }
        }
    }
}