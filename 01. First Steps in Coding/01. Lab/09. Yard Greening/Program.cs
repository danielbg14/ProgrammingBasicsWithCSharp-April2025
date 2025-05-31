double pricepermeter = 7.61;
double discount = 0.18;

double meters = double.Parse(Console.ReadLine());

double priceall = meters * pricepermeter;
double discountprice = discount * priceall;
double endprice = priceall - discountprice;

Console.WriteLine($"The final price is: {endprice} lv.");
Console.WriteLine($"The discount is: {discountprice} lv.");