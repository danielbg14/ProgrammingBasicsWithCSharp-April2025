int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int amountFishers = int.Parse(Console.ReadLine());

double springRentShip = 3000;
double summerAutumnRentShip = 4200;
double winterRentShip = 2600;

double shipPrice = 0;

if (season == "Spring")
{
    shipPrice = springRentShip;
}
else if (season == "Summer" || season == "Autumn")
{
    shipPrice = summerAutumnRentShip;
}
else if (season == "Winter")
{
    shipPrice = winterRentShip;
}

double discount = 1;
if (amountFishers <= 6)
{
    discount = 0.9;
}
else if (amountFishers >= 7 && amountFishers <= 11)
{
    discount = 0.85;
}
else if (amountFishers >= 12)
{
    discount = 0.75;
}

double totalPrice = shipPrice * discount;

if (amountFishers % 2 == 0 && season != "Autumn")
{
    totalPrice = totalPrice * 0.95;
}

double remaining = budget - totalPrice;
double needed = totalPrice - budget;
if (budget >= totalPrice)
{
    Console.WriteLine($"Yes! You have {remaining:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {needed:F2} leva.");
}