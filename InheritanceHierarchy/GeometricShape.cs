namespace InheritanceHierarchy;

public abstract class GeometricShape
{
    protected double area;

    protected virtual double Area
    {
        get => area;
        init => area = value;
    }
    
    private string Color { get; }
    
    protected GeometricShape(string color)
    {
        Color = color;
    }
    
    public virtual void Descriptor()
    {
        Console.WriteLine($"Created a new {Color} {GetType().Name}.");
        Console.WriteLine($"It has an area of {Area:F2}.");
    }
}