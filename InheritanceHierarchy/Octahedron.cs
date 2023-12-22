namespace InheritanceHierarchy;

public sealed class Octahedron : Polyhedron
{
    public Octahedron(double side, string color) : base(color)
    {
        Area = side;
        Volume = side;
    }

    protected override double Area
    {
        get => area;
        init => area = 2 * Math.Sqrt(3) * Math.Pow(value, 2);
    }

    public override double Volume
    {
        get => volume;
        init => volume = (Math.Sqrt(2) / 3) * Math.Pow(value, 3);
    }
}