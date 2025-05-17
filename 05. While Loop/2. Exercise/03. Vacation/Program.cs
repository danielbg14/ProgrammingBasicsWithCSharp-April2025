double neededMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int days = 0;
int spendingDays = 0;

while (availableMoney < neededMoney && spendingDays < 5)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    days++;

    if (action == "spend")
    {
        spendingDays++;
        availableMoney -= amount;
        if (availableMoney < 0)
        {
            availableMoney = 0;
        }
    }
    else if (action == "save")
    {
        spendingDays = 0;
        availableMoney += amount;
    }
}

if (spendingDays == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}
else if (availableMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {days} days.");
}