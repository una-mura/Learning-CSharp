using CircleOperations;

while (true)
{
    Console.Write("New circle's radius value: ");
    var radius = Convert.ToDouble(Console.ReadLine());
    var newCircle = new Circle(radius);
    newCircle.CircleInfo();
    
    Console.Write("Create new circle? (any/N): ");
    var confirmation = Console.ReadLine()!;

    if (string.Equals(confirmation, "N", StringComparison.OrdinalIgnoreCase)) break;

    Console.WriteLine();
}