string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

switch (month)
{
    case "May":
    case "October":
        studioPrice = 50;
        apartmentPrice = 65;
        if (nights > 14)
        {
            studioPrice *= 0.7;
        }
        else if (nights > 7)
        {
            studioPrice *= 0.95;
        }
        break;
    case "June":
    case "September":
        studioPrice = 75.2;
        apartmentPrice = 68.7;
        if (nights > 14)
        {
            studioPrice *= 0.8;
        }
        break;
    case "July":
    case "August":
        studioPrice = 76;
        apartmentPrice = 77;
        break;
}

if (nights > 14)
{
    apartmentPrice *= 0.9;
}

double totalPriceStudio = studioPrice * nights;
double totalPriceApartments = apartmentPrice * nights;

Console.WriteLine($"Apartment: {totalPriceApartments:F2} lv.");
Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");