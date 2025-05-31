int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int bonusTime = minutes + 15;
if (bonusTime >= 60)
{
    hours = hours + 1;
    bonusTime = bonusTime - 60;
}

if (hours >= 24)
{
    hours = hours - 24;
}

if (bonusTime < 10)
{
    Console.WriteLine($"{hours}:0{bonusTime}");
}
else
{
    Console.WriteLine($"{hours}:{bonusTime}");
}
