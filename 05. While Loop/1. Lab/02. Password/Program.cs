string user = Console.ReadLine();
string pass = Console.ReadLine();

string login = Console.ReadLine();
while (login != pass)
{
    login = Console.ReadLine();
}
Console.WriteLine($"Welcome {user}!");