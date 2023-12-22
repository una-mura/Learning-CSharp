namespace InheritanceHierarchy;

public sealed class Triangle : FlatShape
{
    public Triangle(double sideA, double sideB, double sideC, string color) : base(color)
    {
        Area = HeronFormula(sideA, sideB, sideC);
    }
    
    private static double HeronFormula(double sideA, double sideB, double sideC)
    {
        var semiPerimeter = (sideA + sideB + sideC) / 2;
        
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter = sideB) * (semiPerimeter - sideC));
    }
}