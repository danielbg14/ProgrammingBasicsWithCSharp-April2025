int chickenamount = int.Parse(Console.ReadLine());
int fishamount = int.Parse(Console.ReadLine());
int veganamount = int.Parse(Console.ReadLine());

double chickenprice = 10.35;
double fishprice = 12.40;
double veganprice = 8.15;

double chickenmenu = chickenamount * chickenprice;
double fishmenu = fishamount * fishprice;  
double veganmenu = veganamount * veganprice;  
double amountmenu = chickenmenu + fishmenu + veganmenu; 
double dessertprice = 0.2 * amountmenu; 
double deliveryprice = 2.50;
double totalamount = amountmenu + dessertprice + deliveryprice;

Console.WriteLine(totalamount);