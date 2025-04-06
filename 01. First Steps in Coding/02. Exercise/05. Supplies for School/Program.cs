int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pricepens = pens * 5.80;
double pricemarkers = markers * 7.20;
double priceliters = liters * 1.20;
double all = pricepens + pricemarkers + priceliters;
double withdiscount = all - (all * discount / 100);

Console.WriteLine(withdiscount);