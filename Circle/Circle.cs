namespace CircleOperations;

public class Circle
{
    private readonly double area, diameter, perimeter, radius;

    public Circle(double radius)
    {
        this.radius = radius;
        
        area = Math.PI * Math.Pow(radius, 2);
        diameter = 2 * radius;
        perimeter = 2 * Math.PI * radius;
    }

    public void CircleInfo()
    {
        Console.WriteLine("New circle created!\n");

        Console.WriteLine($"Area: {area:0.00}");
        Console.WriteLine($"Diameter: {diameter:0.00}");
        Console.WriteLine($"Perimeter: {perimeter:0.00}");
        Console.WriteLine($"Radius: {radius:0.00}\n");
    }
}