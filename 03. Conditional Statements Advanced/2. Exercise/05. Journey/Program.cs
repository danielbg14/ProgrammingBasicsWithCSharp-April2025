double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string location = "";

double percent = 1;
if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        location = "Camp";
        percent = 0.30;
    }
    else if (season == "winter")
    {
        location = "Hotel";
        percent = 0.70;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        location = "Camp";
        percent = 0.4;
    }
    else if (season == "winter")
    {
        location = "Hotel";
        percent = 0.8;
    }
}
else
{
    destination = "Europe";
    percent = 0.9;
    location = "Hotel";
}

double totalPrice = budget * percent;
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{location} - {totalPrice:F2}");