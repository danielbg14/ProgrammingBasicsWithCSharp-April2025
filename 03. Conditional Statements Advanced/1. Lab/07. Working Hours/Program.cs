int hour = int.Parse(Console.ReadLine());
string weekDay = Console.ReadLine();

if (hour >= 10 && hour <= 18 && weekDay != "Sunday")
{
    if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday" || weekDay == "Saturday")
    {
        Console.WriteLine("open");
    }
}
else
{
    Console.WriteLine("closed");
}
