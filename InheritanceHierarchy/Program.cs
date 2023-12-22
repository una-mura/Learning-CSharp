using InheritanceHierarchy;

var endProgram = false;

while (endProgram == false)
{
    Console.WriteLine("Welcome to the Geometric Shape Simulator!\n");
    Console.WriteLine("Shape list:\n");
    
    Console.WriteLine
    (
        "0. End program\n" +
        "1. Create circle\n" +
        "2. Create cube\n" +
        "3. Create octahedron\n" +
        "4. Create rectangle\n" +
        "5. Create sphere\n" +
        "6. Create square\n" +
        "7. Create tetrahedron\n" +
        "8. Create triangle\n"
    );
    
    Console.Write("Select a shape by number: ");
    var shapeCode = Convert.ToInt32(Console.ReadLine());

    GeometricShape? newShape = null;
    double radius, side;
    string? color;
    
    switch (shapeCode)
    {
        case 0:
            endProgram = true;
            break;
        
        case 1:
            Console.Write("\nDefine circle radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define circle color: ");
            color = Console.ReadLine();

            newShape = new Circle(radius, color!);
            break;
        
        case 2:
            Console.Write("Define cube side: ");
            side = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define cube color: ");
            color = Console.ReadLine();

            newShape = new Cube(side, color!);
            break;
        
        case 3:
            Console.Write("Define octahedron face side value: ");
            side = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define octahedron color: ");
            color = Console.ReadLine();

            newShape = new Octahedron(side, color!);
            break;
        
        case 4:
            Console.Write("Define rectangle bottom: ");
            var bottom = Convert.ToDouble(Console.ReadLine());

            Console.Write("Define rectangle height: ");
            var height = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define rectangle color: ");
            color = Console.ReadLine();

            newShape = new Rectangle(bottom, height, color!);
            break;
        
        case 5:
            Console.Write("Define sphere radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define sphere color: ");
            color = Console.ReadLine();

            newShape = new Sphere(radius, color!);
            break;
        
        case 6:
            Console.Write("Define square side: ");
            side = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define square color: ");
            color = Console.ReadLine();

            newShape = new Square(side, color!);
            break;
        
        case 7:
            Console.Write("Define tetrahedron face side value: ");
            side = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define tetrahedron color: ");
            color = Console.ReadLine();

            newShape = new Tetrahedron(side, color!);
            break;
        
        case 8:
            Console.Write("Define triangle side A: ");
            var sideA = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define triangle side B: ");
            var sideB = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define triangle side C: ");
            var sideC = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Define triangle color: ");
            color = Console.ReadLine();

            newShape = new Triangle(sideA, sideB, sideC, color!);
            break;
        
        default:
            Console.WriteLine("Invalid code.");
            break;
    }
    
    Console.WriteLine();

    if (shapeCode != 0)
    {
        newShape?.Descriptor();
        Console.WriteLine();
    }

    else
    {
        Console.WriteLine("Ending...");
    }
}