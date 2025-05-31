int yearlytax = int.Parse(Console.ReadLine());

double sneakers = yearlytax - (yearlytax * 0.40);
double ekip = sneakers - (sneakers * 0.20);
double ball = 0.25 * ekip;
double accessories = 0.2 * ball;
double totalamount = yearlytax + sneakers + ekip + ball + accessories;

Console.WriteLine(totalamount);