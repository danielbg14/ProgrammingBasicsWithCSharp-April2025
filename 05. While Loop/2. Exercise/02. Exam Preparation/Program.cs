int negativeGrades = int.Parse(Console.ReadLine());
int failedTimes = 0;
int solvedProblems = 0;
double gradesSum = 0;
string lastProblem = "";
bool isFailed = true;

while (failedTimes < negativeGrades)
{
    string problem = Console.ReadLine();
    if ("Enough" == problem)
    {
        isFailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4)
    {
        failedTimes++;
    }
    gradesSum += grade;
    solvedProblems++;
    lastProblem = problem;
}

if (isFailed)
{
    Console.WriteLine($"You need a break, {negativeGrades} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {gradesSum / solvedProblems:F2}");
    Console.WriteLine($"Number of problems: {solvedProblems}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
