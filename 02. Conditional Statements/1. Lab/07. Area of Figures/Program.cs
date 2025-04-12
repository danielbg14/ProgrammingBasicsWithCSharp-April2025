string shape = Console.ReadLine();

if (shape == "square")
{
    double sizeSquare = double.Parse(Console.ReadLine());
    double areaSquare = sizeSquare * sizeSquare;
    Console.WriteLine($"{areaSquare:F3}");
}
else if (shape == "rectangle")
{
    double lengthRect1 = double.Parse(Console.ReadLine());
    double lengthRect2 = double.Parse(Console.ReadLine());
    double areaRect = lengthRect1 * lengthRect2;
    Console.WriteLine($"{areaRect:F3}");
}
else if (shape == "circle")
{
    double radiusCircle = double.Parse(Console.ReadLine());
    double areaCircle = Math.PI * radiusCircle * radiusCircle;
    Console.WriteLine($"{areaCircle:F3}");
}
else if (shape == "triangle")
{
    double lengthTriangle = double.Parse(Console.ReadLine());
    double heightTriangle = double.Parse(Console.ReadLine());
    double areaTriangle = (lengthTriangle * heightTriangle) / 2;
    Console.WriteLine($"{areaTriangle:F3}");
}
else
    Console.WriteLine("Not valid shape!");
