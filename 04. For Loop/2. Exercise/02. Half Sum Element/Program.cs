int n = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;

    if (number > max)
    {
        max = number;
    }
}

sum -= max;

if (max == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int difference = Math.Abs(max - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}