using System;

// 1 masala
int sum = 0;
int i = 1;

while (i <= 1000)
{
    if (i % 2 != 0)
    {
        sum += i;
    }
    i++;
}

Console.WriteLine("1 dan 1000 gacha bo‘lgan toq sonlar yig‘indisi: " + sum);

// 2 masala
int[] numbers = { 3, 7, 2, 9, 4, 1, 8 };
int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

int product = min * max;
Console.WriteLine("Eng katta va eng kichik qiymatlarning ko‘paytmasi: " + product);


// 3 masala
Console.Write("Butun son kiriting: ");
int x = int.Parse(Console.ReadLine());
int factorial = 1;

while (x > 1)
{
    factorial *= x;
    x--;
}

Console.WriteLine("Faktorial: " + factorial);
