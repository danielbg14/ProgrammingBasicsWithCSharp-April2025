int stayingDays = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string review = Console.ReadLine();

double priceForType = 0;
double nights = stayingDays - 1;
double discount = 1;

if (type == "room for one person")
{
    priceForType = 18 ;
}
else if (type == "apartment")
{
    priceForType = 25;
    if (nights < 10)
    {
        discount = 0.7;
    }
    else if (nights <= 15)
    {
        discount = 0.65;
    }
    else
    {
        discount = 0.5;
    }
}
else if (type == "president apartment")
{
    priceForType = 35;
    if (nights < 10)
    {
        discount = 0.9;
    }
    else if (nights <= 15)
    {
        discount = 0.85;
    }
    else
    {
        discount = 0.8;
    }
}

double totalPrice = nights * priceForType * discount;

if (review == "positive")
{
    totalPrice *= 1.25;
}
else if (review == "negative")
{
    totalPrice *= 0.9;
}

Console.WriteLine($"{totalPrice:F2}");
