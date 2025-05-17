int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int room = width * length * height;
string input = "";

while ((input = Console.ReadLine()) != "Done")
{
    int boxesVolume = int.Parse(input);
    room -= boxesVolume;

    if (room < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(room)} Cubic meters more.");
        return;
    }
}
Console.WriteLine($"{room} Cubic meters left.");
