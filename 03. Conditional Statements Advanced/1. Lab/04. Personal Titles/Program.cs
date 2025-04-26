double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

if (gender == "m" && age >= 16.0)
{
    Console.WriteLine("Mr.");
}
else if (gender == "m" && age < 16.0)
{
    Console.WriteLine("Master");
}
else if (gender == "f" && age >= 16.0)
{
    Console.WriteLine("Ms.");
}
else if (gender == "f" && age < 16.0)
{
    Console.WriteLine("Miss");
}