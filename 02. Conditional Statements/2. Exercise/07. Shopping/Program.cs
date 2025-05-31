double budget = double.Parse(Console.ReadLine());
int GPU = int.Parse(Console.ReadLine());
int CPU = int.Parse(Console.ReadLine());
int RAM = int.Parse(Console.ReadLine());

int priceGPU = 250;

double totalGPU = GPU * priceGPU;
double priceCPU = (0.35 * totalGPU) * CPU;
double priceRAM = (0.10 * totalGPU) * RAM;

double totalCost = totalGPU + priceCPU + priceRAM;

if (GPU > CPU)
{
    totalCost -= totalCost * 0.15;
}

if (totalCost <= budget)
{
    double remaining = budget - totalCost;
    Console.WriteLine($"You have {remaining:F2} leva left!");
}
else
{
    double needed = totalCost - budget;
    Console.WriteLine($"Not enough money! You need {needed:F2} leva more!");
}