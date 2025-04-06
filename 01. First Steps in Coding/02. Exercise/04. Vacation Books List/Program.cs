int bookpages = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int time = bookpages / pages;
int needtime = time / days;

Console.WriteLine(needtime);