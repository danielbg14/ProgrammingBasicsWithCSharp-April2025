int n = int.Parse(Console.ReadLine());

int p1Count = 0;
int p2Count = 0;
int p3Count = 0;
int p4Count = 0;
int p5Count = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        p1Count++;
    }
    else if (number < 400)
        p2Count++;
    else if (number < 600)
        p3Count++;
    else if (number < 800)
        p4Count++;
    else
        p5Count++;
}

double p1 = 100 * (double)p1Count / n;
double p2 = 100 * (double)p2Count / n;
double p3 = 100 * (double)p3Count / n;
double p4 = 100 * (double)p4Count / n;
double p5 = 100 * (double)p5Count / n;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");