double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeFor1Meter = double.Parse(Console.ReadLine());

double neededToSwim = distance * timeFor1Meter; 
double every15Meters = Math.Floor((distance / 15)) * 12.5;
double totalTime = neededToSwim + every15Meters;

if (record > totalTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    double neededTime = totalTime - record;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}
