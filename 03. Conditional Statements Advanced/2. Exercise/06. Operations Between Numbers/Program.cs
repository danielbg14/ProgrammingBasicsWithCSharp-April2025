int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char o = char.Parse(Console.ReadLine());

if ((o == '/' || o == '%') && n2 == 0)
{
    Console.WriteLine($"Cannot divide {n1} by zero");
}
else
    switch (o)
    {
        case '+':
            double sum = n1 + n2;
            string evenorodd = "";
            if (sum % 2 == 0)
            {
                evenorodd = "even";
            }
            else
            {
                evenorodd = "odd";
            }
            Console.WriteLine($"{n1} + {n2} = {sum} - {evenorodd}");
            break;
        case '-':
            double subtract = n1 - n2;
            if (Math.Abs(subtract) % 2 == 0)
            {
                evenorodd = "even";
            }
            else
            {
                evenorodd = "odd";
            }
            Console.WriteLine($"{n1} - {n2} = {subtract} - {evenorodd}");
            break;
        case '*':
            double multiply = n1 * n2;
            if (multiply % 2 == 0)
            {
                evenorodd = "even";
            }
            else
            {
                evenorodd = "odd";
            }
            Console.WriteLine($"{n1} * {n2} = {multiply} - {evenorodd}");
            break;
        case '/':
            double divide = (double)n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {divide:F2}");
            break;
        case '%':
            double number = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {number}");
            break;
    }