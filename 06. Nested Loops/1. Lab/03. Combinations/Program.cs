int n = int.Parse(Console.ReadLine());

int validCombinationsCount = 0;
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        for (int k = 0; k <= n; k++)
        {
            if (i + j + k == n)
            {
                validCombinationsCount++;
            }
        }
    }
}
Console.WriteLine(validCombinationsCount);