using System;

string inputRadius = Console.ReadLine();
decimal radius = Convert.ToDecimal(inputRadius);
decimal s = 3.14m*radius*radius; 
decimal l = 2*3.14m*radius; 
Console.WriteLine($"S={s}, L={l}");

string inputValue = Console.ReadLine();
double sum = Convert.ToInt32(inputValue) * 12400;
Console.WriteLine($"{sum} so'm");

int age = Convert.ToInt32(Console.ReadLine());
int day = 365*age;
Console.WriteLine(day);