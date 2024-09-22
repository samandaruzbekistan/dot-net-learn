using System;

Console.Write("Birinchi raqamni kiriting: ");
double raqam1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Amalni kiriting (+, -, *, /): ");
char amal = Convert.ToChar(Console.ReadLine());

Console.Write("Ikkinchi raqamni kiriting: ");
double raqam2 = Convert.ToDouble(Console.ReadLine());


double natija = 0;
switch (amal)
{
    case '+':
        natija = raqam1 + raqam2;
        break;
    case '-':
        natija = raqam1 - raqam2;
        break;
    case '*':
        natija = raqam1 * raqam2;
        break;
    case '/':
        if (raqam2 != 0)
        {
            natija = raqam1 / raqam2;
        }
        else
        {
            Console.WriteLine("Nolga bo'lib bo'lmaydi!");
            return;
        }
        break;
    default:
        Console.WriteLine("Noto'g'ri amal kiritildi.");
        return;
}


Console.WriteLine($"Natija: {natija}");


Console.Write("Musbat butun sonni kiriting (N): ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("Iltimos, musbat butun son kiriting.");
    return;
}

int yigindi = 0;
for (int i = 1; i <= N; i++)
{
    yigindi += i;
}

Console.WriteLine($"1 dan {N} gacha bo'lgan sonlar yig'indisi: {yigindi}");





Console.Write("Raqam kiriting: ");
int raqam = Convert.ToInt32(Console.ReadLine());

if (raqam % 2 == 0)
{
    Console.WriteLine("Juft");
}
else
{
    Console.WriteLine("Toq");
}