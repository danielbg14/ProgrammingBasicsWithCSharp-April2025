int amountGroups = int.Parse(Console.ReadLine());

int group1 = 0, group2 = 0, group3 = 0, group4 = 0, group5 = 0;

for (int i = 0; i < amountGroups; i++)
{
    int amountPeople = int.Parse(Console.ReadLine());

    if (amountPeople <= 5)
    {
        group1 += amountPeople;
    }
    else if (amountPeople <= 12)
    { 
        group2 += amountPeople;
    }
    else if (amountPeople <= 25)
    {
        group3 += amountPeople;
    }
    else if (amountPeople <= 40)
    {
        group4 += amountPeople;
    }
    else
    {
        group5 += amountPeople;
    }
}

int allPeople = group1 + group2 + group3 + group4 + group5;

double Musala = 100.0 * group1 / allPeople;
double Monblan = 100.0 * group2 / allPeople;
double Kilimandjaro = 100.0 * group3 / allPeople;
double K2 = 100.0 * group4 / allPeople;
double Everest = 100.0 * group5 / allPeople;

Console.WriteLine($"{Musala:f2}%");
Console.WriteLine($"{Monblan:f2}%");
Console.WriteLine($"{Kilimandjaro:f2}%");
Console.WriteLine($"{K2:f2}%");
Console.WriteLine($"{Everest:F2}%");