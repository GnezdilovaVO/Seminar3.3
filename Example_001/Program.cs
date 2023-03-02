int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSum(int A)
{
    int b = 1;
    int Sum = 0;
    while (b <= A)
    {
        Sum = Sum + b;
        b++;
    }
    return Sum;
}

int a = GetNumber("Введите число: ");
int sum = GetSum(a);



Console.WriteLine(sum);