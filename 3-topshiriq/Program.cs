using System;

Console.Write("Son kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());

if (Tubmi(son))
{
    Console.WriteLine("Tub");
}
else
{
    Console.WriteLine("Tub emas");
}

static bool Tubmi(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}




Console.Write("Son kiriting: ");
int son2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Bo'luvchilari: ");
for (int i = 2; i <= 10; i++)
{
    if (son2 % i == 0)
    {
        Console.Write(i + " ");
    }
}

Console.Write("Son kiriting: ");
int son3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Darajani kiriting: ");
int daraja = Convert.ToInt32(Console.ReadLine());

int natija = 1;
for (int i = 0; i < daraja; i++)
{
    natija *= son3;
}

Console.WriteLine($"{son3} ning {daraja}-darajasi: {natija}");



int[] harajatlar = {150, 230, 80, 120};
int yigindi = 0;

foreach (int qiymat in harajatlar)
{
    yigindi += qiymat;
}

Console.WriteLine($"Harajatlar yig'indisi: {yigindi}");





Console.Write("Son kiriting: ");
int son4 = Convert.ToInt32(Console.ReadLine());

if (Armstrongmi(son4))
{
    Console.WriteLine($"{son} Armstrong son");
}
else
{
    Console.WriteLine($"{son} Armstrong son emas");
}

static bool Armstrongmi(int n)
{
    int temp = n, sum = 0, digit, length = n.ToString().Length;
    while (temp > 0)
    {
        digit = temp % 10;
        sum += (int)Math.Pow(digit, length);
        temp /= 10;
    }
    return sum == n;
}






Console.Write("Son kiriting: ");
int son5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sifatli bo'luvchilar: ");
for (int i = 1; i <= son5; i++)
{
    if (son5 % i == 0)
    {
        Console.Write(i + " ");
    }
}