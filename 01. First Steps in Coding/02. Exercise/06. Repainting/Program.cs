int nailon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int razreditel = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double pricefornailon = 1.50;
double priceforpaint = 14.50;
double priceforrazreditel = 5.0;
double pricebags = 0.40;

double pricenailon = (nailon + 2) * pricefornailon;
double pricepaint = (paint + (paint * 0.10)) * priceforpaint;
double pricerazreditel = razreditel * priceforrazreditel;

double allamount = pricenailon + pricepaint + pricerazreditel + pricebags;
double amountworkers = (allamount * 0.3) * hours;
double finalamount = allamount + amountworkers;

Console.WriteLine(finalamount);