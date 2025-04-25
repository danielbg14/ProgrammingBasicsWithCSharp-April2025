string nameOfSeries = Console.ReadLine();
int lengthEpisode = int.Parse(Console.ReadLine());
int lengthBreak = int.Parse(Console.ReadLine());

double lunchTime = lengthBreak * 0.125;
double breakTime = lengthBreak * 0.25;
double leftTime = lengthBreak - lunchTime - breakTime;

if (leftTime >= lengthEpisode)
{
    double freeTime = Math.Ceiling(leftTime - lengthEpisode);
    Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {freeTime} minutes free time.");
}
else
{
    double neededTime = Math.Ceiling(lengthEpisode - leftTime);
    Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {neededTime} more minutes.");
}