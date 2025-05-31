string text = Console.ReadLine();

int max = int.MinValue;

while (text != "Stop")
{
    int number = int.Parse(text);

    if (number > max)
    {
        max = number;
    }

    text = Console.ReadLine();
}

Console.WriteLine(max);