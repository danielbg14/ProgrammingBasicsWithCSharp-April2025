string product = Console.ReadLine();
string town = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());

double price = 0;

if (town == "Sofia")
{
    switch (product)
    {
        case "coffee":
            price = 0.5;
            break;
        case "water":
            price = 0.8;
            break;
        case "beer":
            price = 1.2;
            break;
        case "sweets":
            price = 1.45;
            break;
        case "peanuts":
            price = 1.6;
            break;
    }
}
else if (town == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            price = 0.4;
            break;
        case "water":
            price = 0.7;
            break;
        case "beer":
            price = 1.15;
            break;
        case "sweets":
            price = 1.3;
            break;
        case "peanuts":
            price = 1.5;
            break;
    }
}
else if (town == "Varna")
{
    switch (product)
    {
        case "coffee":
            price = 0.45;
            break;
        case "water":
            price = 0.7;
            break;
        case "beer":
            price = 1.1;
            break;
        case "sweets":
            price = 1.35;
            break;
        case "peanuts":
            price = 1.55;
            break;
    }
}

double priceAll = amount * price;
Console.WriteLine(priceAll);