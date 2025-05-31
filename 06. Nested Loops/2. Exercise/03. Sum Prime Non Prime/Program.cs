string input = Console.ReadLine();
int primeSum = 0;
int nonPrimeSum = 0;


while (input != "stop")
{
    int number = int.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        number = 0;
    }
    bool isPrime = true;

    for (int i = 2; i <= number-1; i++)
    {
        if (number == 2)
        {
            break;
        }
        if (number % i == 0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        primeSum += number;
    }
    else
    {
        nonPrimeSum += number;
    }
    input = Console.ReadLine();
    isPrime = true;
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");