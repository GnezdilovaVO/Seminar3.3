int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberOfDigits(int x)
{
    int res = 0;
    while (x % 10 != 0)
    {
        x = x / 10;
        res++;
    }
    return res;
}

int n = GetNumber("Введите число N: ");
int i = GetNumberOfDigits(n);
Console.WriteLine(i);