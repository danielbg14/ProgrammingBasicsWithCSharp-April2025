int degrees = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (day == "Morning")
{
    if (degrees >= 10 && degrees <= 18)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
    }
    else if (degrees > 18 && degrees <= 24)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
    }
    else if (degrees >= 25)
    {
        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
    }
}
else if (day == "Afternoon")
{
    if (degrees >= 10 && degrees <= 18)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
    }
    else if (degrees > 18 && degrees <= 24)
    {
        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
    }
    else if (degrees >= 25)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
    }
}
else if (day == "Evening")
{
    if (degrees >= 10 && degrees <= 18)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
    }
    else if (degrees > 18 && degrees <= 24)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Sandals.");
    }
    else if (degrees >= 25)
    {
        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
    }
}
