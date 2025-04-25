double priceForTrip = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int talkingDolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

// PRICES

double pricePuzzles = 2.60;
double priceDolls = 3;
double priceBears = 4.10;
double priceMinions = 8.20;
double priceTrucks = 2;

// CALCULATIONS

double amount = puzzles * pricePuzzles + talkingDolls * priceDolls + teddyBears * priceBears + minions * priceMinions + trucks * priceTrucks;
double toysAmount = puzzles + talkingDolls + teddyBears + minions + trucks;

if (toysAmount >= 50)
{
    double discount = 0.25 * amount;
    double amountWithDiscount = amount - discount;
    double rent = 0.10 * amountWithDiscount;
    double profit = amountWithDiscount - rent;
    if (profit >= priceForTrip)
    {
        double remainingMoney = profit - priceForTrip;
        Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
    }
    else
    {
        double remainingMoney = priceForTrip - profit;
        Console.WriteLine($"Not enough money! {remainingMoney:F2} lv needed.");
    }
}
else
{
    double rent = 0.10 * amount;
    double profit = amount - rent;
    if (profit >= priceForTrip)
    {
        double remainingMoney = profit - priceForTrip;
        Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
    }
    else
    {
        double remainingMoney = priceForTrip - profit;
        Console.WriteLine($"Not enough money! {remainingMoney:F2} lv needed.");
    }
}
