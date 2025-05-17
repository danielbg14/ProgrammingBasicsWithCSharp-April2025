string steps = Console.ReadLine();
int stepsGoal = 10000;
int sumSteps = 0;

while (steps != "Going home")
{
    int currentSteps = int.Parse(steps);
    sumSteps += currentSteps;

    if (sumSteps >= stepsGoal)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{sumSteps - stepsGoal} steps over the goal!");
        return;
    }
    steps = Console.ReadLine();
}

if (steps == "Going home")
{
    int stepsToHome = int.Parse(Console.ReadLine());
    sumSteps += stepsToHome;
}
if (sumSteps >= stepsGoal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{sumSteps - stepsGoal} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsGoal - sumSteps} more steps to reach goal.");
}
