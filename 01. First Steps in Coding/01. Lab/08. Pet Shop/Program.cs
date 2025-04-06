int dogbag = int.Parse(Console.ReadLine());
int catbag = int.Parse(Console.ReadLine());

double dogbagprice = 2.50;
int catbagprice = 4;

double dogprice = dogbagprice * dogbag;
int catprice = catbagprice * catbag;

double bothprice = dogprice + catprice;

Console.WriteLine($"{bothprice} lv.");