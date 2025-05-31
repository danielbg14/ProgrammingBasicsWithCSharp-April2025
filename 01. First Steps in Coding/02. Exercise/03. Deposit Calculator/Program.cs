double deposited = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double interest = double.Parse(Console.ReadLine())/100;

double amount = deposited + months * ((deposited * interest)/12);

Console.WriteLine(amount);