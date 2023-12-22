namespace InheritanceHierarchy;

public abstract class NonFlatShape : GeometricShape
{
    protected double volume;

    protected NonFlatShape(string color) : base(color)
    { }

    public virtual double Volume
    {
        get => volume;
        init => volume = value;
    }

    public override void Descriptor()
    {
        base.Descriptor();
        Console.WriteLine($"It has a volume of {Volume:F2}.");
    }
}