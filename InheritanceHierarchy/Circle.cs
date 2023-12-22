namespace InheritanceHierarchy;

public sealed class Circle : FlatShape
{
    public Circle(double radius, string color) : base(color)
    {
        Area = radius;
    }

    protected override double Area
    {
        get => area;
        init => area = Math.PI * Math.Pow(value, 2);
    }
}