string password = Console.ReadLine();
string correctpass = "s3cr3t!P@ssw0rd";

if (password == correctpass)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}
