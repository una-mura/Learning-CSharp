namespace InheritanceHierarchy;

public sealed class Sphere : NonFlatShape
{
    public Sphere(double radius, string color) : base(color)
    {
        Area = radius;
        Volume = radius;
    }

    protected override double Area
    {
        get => area;
        init => area = 4 * Math.PI * Math.Pow(value, 2);
    }

    public override double Volume
    {
        get => volume;
        init => volume = Math.PI * Math.Pow(value, 3) * 4 / 3;
    }
}