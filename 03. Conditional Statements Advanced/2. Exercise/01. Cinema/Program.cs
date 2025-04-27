string typeProjection = Console.ReadLine();
double rows = double.Parse(Console.ReadLine());
double columns = double.Parse(Console.ReadLine());

double priceProjection = 0;

if (typeProjection == "Premiere")
{
    priceProjection = 12.0;
}
else if (typeProjection == "Normal")
{
    priceProjection = 7.50;
}
else if (typeProjection == "Discount")
{
    priceProjection = 5;
}

double finalPrice = priceProjection * rows * columns;
Console.WriteLine($"{finalPrice:F2} leva");
