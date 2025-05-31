string favoriteBook = Console.ReadLine();
int books = 0;
bool isBookFound = false;

string nextBookName = Console.ReadLine();
while (nextBookName != "No More Books")
{
    if (nextBookName == favoriteBook)
    {
        isBookFound = true;
        break;
    }
    books++;
    nextBookName = Console.ReadLine();
}

if (isBookFound)
{
    Console.WriteLine($"You checked {books} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {books} books.");
}
