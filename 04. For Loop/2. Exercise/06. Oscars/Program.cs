string actorName = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());

double nomination = 1250.5;

for (int i = 0; i < judges && pointsFromAcademy <= nomination; i++)
{
    string judge = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    pointsFromAcademy += judge.Length * judgePoints / 2;
}

if (pointsFromAcademy > nomination)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:F1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorName} you need {nomination - pointsFromAcademy:F1} more!");
}
