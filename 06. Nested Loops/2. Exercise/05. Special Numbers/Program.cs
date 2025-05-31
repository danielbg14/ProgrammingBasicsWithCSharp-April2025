int n = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{
    string currentNum = i.ToString();
    bool isSpecial = true;

    for (int symbol = 0; symbol < currentNum.Length; symbol++)
    {
        int currentDigit = int.Parse(currentNum[symbol].ToString());

        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}
