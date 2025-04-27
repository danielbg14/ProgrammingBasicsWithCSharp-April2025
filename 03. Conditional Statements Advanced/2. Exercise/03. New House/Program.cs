string typeFlowers = Console.ReadLine();
int amountFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double roses = 5;
double dahlias = 3.8;
double tulips = 2.8;
double narcissus = 3;
double gladiolus = 2.5;

double priceFlower = 0;
double discount = 1;

if (typeFlowers == "Roses")
{
    priceFlower = roses;
    if (amountFlowers > 80)
    {
        discount = 0.9;
    }
}
else if (typeFlowers == "Dahlias")
{
    priceFlower = dahlias;
    if (amountFlowers > 90)
    {
        discount = 0.85;
    }
}
else if (typeFlowers == "Tulips")
{
    priceFlower = tulips;
    if (amountFlowers > 80)
    {
        discount = 0.85;
    }
}
else if (typeFlowers == "Narcissus")
{
    priceFlower = narcissus;
    if (amountFlowers < 120)
    {
        discount = 1.15;
    }
}
else if (typeFlowers == "Gladiolus")
{
    priceFlower = gladiolus;
    if (amountFlowers < 80)
    {
        discount = 1.2;
    }
}

double finalPrice = priceFlower * amountFlowers * discount;

if (finalPrice <= budget)
{
    double remainingMoney = budget - finalPrice;
    Console.WriteLine($"Hey, you have a great garden with {amountFlowers} {typeFlowers} and {remainingMoney:F2} leva left.");
}
else
{
    double neededMoney = finalPrice - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
}