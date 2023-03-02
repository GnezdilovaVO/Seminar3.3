Console.WriteLine("Введите число ");
int n =  Convert.ToInt32(Console.ReadLine());

int i=0;
while(n%10 != 0)
{
    n = n/10;
    i++;
}
Console.WriteLine(i);