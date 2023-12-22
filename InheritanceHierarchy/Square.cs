namespace InheritanceHierarchy;

public sealed class Square : Quadrilateral
{
    public Square(double side, string color) : base(color)
    {
        Area = side;
    }

    protected override double Area
    {
        get => area;
        init => area = value * value;
    }
}