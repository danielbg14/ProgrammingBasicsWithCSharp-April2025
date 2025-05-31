int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magic = int.Parse(Console.ReadLine());

bool isSumFound = false;
int combinations = 0;
for (int x1 = start; x1 <= end; x1++)
{
    for (int x2 = start; x2 <= end; x2++)
    {
        combinations++;
        
        if (x1 + x2 == magic)
        {
            isSumFound = true;
            Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magic})");
            break;
        }
    }

    if (isSumFound)
    {
        break;
    }
}
if (!isSumFound)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magic}");
}
