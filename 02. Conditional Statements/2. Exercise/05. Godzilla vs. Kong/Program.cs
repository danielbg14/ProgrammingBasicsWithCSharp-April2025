double budgetForMovie = double.Parse(Console.ReadLine());
int statisti = int.Parse(Console.ReadLine());
double priceForClothForOneStatist = double.Parse(Console.ReadLine());

double decor = budgetForMovie * 0.10;
double cloth = statisti * priceForClothForOneStatist;

if (statisti > 150)
{
    cloth = cloth * 0.90;
}

double total = decor + cloth;
if (total > budgetForMovie)
{
    double needed = total - budgetForMovie;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {needed:F2} leva more.");
}
else
{
    double left = budgetForMovie - total;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {left:F2} leva left.");
}
