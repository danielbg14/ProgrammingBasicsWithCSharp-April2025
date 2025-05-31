string text = Console.ReadLine();

int min = int.MaxValue;

while (text != "Stop")
{
    int number = int.Parse(text);

    if (number < min)
    {
        min = number;
    }

    text = Console.ReadLine();
}

Console.WriteLine(min);