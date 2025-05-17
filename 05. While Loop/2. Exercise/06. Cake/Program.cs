int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int pieces = width * length;
string input = "";

while ((input = Console.ReadLine()) != "STOP")
{
    int currentPieces = int.Parse(input);
    pieces -= currentPieces;

    if (pieces < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
        break;
    }
}

if (pieces >= 0)
{
    Console.WriteLine($"{pieces} pieces are left.");
}
