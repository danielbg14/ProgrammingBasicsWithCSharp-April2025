int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine())/100;

double aquarium = length * width * height;
double liters = aquarium / 1000;
double neededliters = liters * (1 - percent);

Console.WriteLine(neededliters);