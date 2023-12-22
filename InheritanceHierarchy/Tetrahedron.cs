namespace InheritanceHierarchy;

public sealed class Tetrahedron : Polyhedron
{
    public Tetrahedron(double side, string color) : base(color)
    {
        Area = side;
        Volume = side;
    }

    protected override double Area
    {
        get => area;
        init => area = Math.Pow(value, 2) * Math.Sqrt(3);
    }

    public override double Volume
    {
        get => volume;
        init => volume = Math.Pow(value, 3) * (6 * Math.Sqrt(2));
    }
}