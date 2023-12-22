namespace InheritanceHierarchy;

public sealed class Rectangle : Quadrilateral
{
    public Rectangle(double bottom, double height, string color) : base(color)
    {
        Area = bottom * height;
    }
}