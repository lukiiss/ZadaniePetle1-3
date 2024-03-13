
using System;
Console.WriteLine("");
Console.WriteLine("Zadanie 1");
Console.WriteLine("");

static bool CzyPierwsza(int n)
{
    if (n < 2) return false;
    for (int d = 2; d * d <= n; d++)
        if (n % d == 0) return false;
    return true;
}

    int count = 0;
for (int i = 1; i <= 100; i++)
{
    if (CzyPierwsza(i))
        count++;
}
Console.WriteLine("Ilość liczb pierwszych w przedziale od 1 do 100: " + count);

Console.WriteLine("");
Console.WriteLine("Zadanie 2");
Console.WriteLine("");

int a = 0;

do
{
    if(a % 2 == 0)
    {
        Console.Write($"{a} ");
    }
    a++;
} 
while (a <= 100);

Console.WriteLine("");
Console.WriteLine("Zadanie 3");
Console.WriteLine("");

int x = 0;
int y = 0;
int z;
for (int n = 0; n < 5; n++)
{
    z = x + y;
    x = y + z;
    y = z + x;
    if (x == 0)
    {
        x++;
    }
    if (y == 0)
    {
        y++;
    }
    Console.WriteLine(z);
    Console.WriteLine(x);
    Console.WriteLine(y);
}