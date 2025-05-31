string name = Console.ReadLine();
double grades = 1;
double sum = 0;
int badGrades = 0;

while (grades <= 12)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade >= 4.00)
    {
        sum += grade;
        grades++;
    }
    else
    {
        badGrades++;
        if (badGrades >= 2)
        {
            Console.WriteLine($"{name} has been excluded at {grades} grade");
            break;
        }
    }
}
if (badGrades < 2)
{
    double average = sum / 12;
    Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
}
