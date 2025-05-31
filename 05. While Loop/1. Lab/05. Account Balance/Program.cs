string text = Console.ReadLine();

double sum = 0;

while (text != "NoMoreMoney")
{
    double money = double.Parse(text);

    if (money < 0)
    {
        Console.WriteLine($"Invalid operation!");
        break;
    }
    sum += money;
    Console.WriteLine($"Increase: {money:F2}");
    text = Console.ReadLine();
}

Console.WriteLine($"Total: {sum:F2}");