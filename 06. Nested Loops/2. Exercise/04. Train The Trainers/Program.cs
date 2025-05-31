int n = int.Parse(Console.ReadLine());
string presentationName = "";

double totalGrades = 0;
int presentations = 0;

while ((presentationName = Console.ReadLine()) != "Finish")
{
    double currentGrade = 0;
    string presentation = presentationName;
    presentations++;
    for (int i = 1; i <= n; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        currentGrade += grade;
        totalGrades += grade;
    }
    Console.WriteLine($"{presentation} - {currentGrade / n:f2}.");
}
Console.WriteLine($"Student's final assessment is {totalGrades / (n * presentations):f2}.");