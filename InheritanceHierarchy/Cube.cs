namespace InheritanceHierarchy;

public sealed class Cube : Polyhedron
{
    public Cube(double side, string color) : base(color)
    {
        Area = side;
        Volume = side;
    }

    protected override double Area
    {
        get => area;
        init => area = 6 * Math.Pow(value, 2);
    }

    public override double Volume
    {
        get => volume;
        init => volume = Math.Pow(value, 3);
    }
}