double change = double.Parse(Console.ReadLine());

double changePennies = Math.Round(change * 100);
int coinsCount = 0;

while (changePennies > 0)
{
    if (changePennies >= 200)
    {
        changePennies -= 200;
    }
    else if (changePennies >= 100)
    {
        changePennies -= 100;
    }
    else if (changePennies >= 50)
    {
        changePennies -= 50;
    }
    else if (changePennies >= 20)
    {
        changePennies -= 20;
    }
    else if (changePennies >= 10)
    {
        changePennies -= 10;
    }
    else if (changePennies >= 5)
    {
        changePennies -= 5;
    }
    else if (changePennies >= 2)
    {
        changePennies -= 2;
    }
    else if (changePennies >= 1)
    {
        changePennies -= 1;
    }
    coinsCount++;
}

Console.WriteLine(coinsCount);