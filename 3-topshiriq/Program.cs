using System;

// 1 masala
Console.Write("Satrni kiriting: ");
string input = Console.ReadLine();

string reversed = new string(input.Reverse().ToArray());
if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("Palindrom emas");
}

// 2 masala
Console.Write("Selsiyusda temperatura kiriting: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + 273.15;

Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");

// 3 masala
Console.Write("Sonlarni kiriting ( vergul bilan ajratilgan): ");
string input = Console.ReadLine();
string[] numbers = input.Split(',');
int[] intNumbers = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    intNumbers[i] = Convert.ToInt32(numbers[i]);
}

Array.Sort(intNumbers);

Console.WriteLine("Tartiblangan qator: " + string.Join(", ", intNumbers));
Array.Reverse(intNumbers);
Console.WriteLine("Teskari tartib: " + string.Join(", ", intNumbers));

// 4 masala
Console.Write("Matn kiriting: ");
string input = Console.ReadLine();

Dictionary<char, int> charFrequency = new Dictionary<char, int>();

foreach (char c in input)
{
    if (charFrequency.ContainsKey(c))
    {
        charFrequency[c]++;
    }
    else
    {
        charFrequency[c] = 1;
    }
}

foreach (KeyValuePair<char, int> pair in charFrequency)
{
    Console.WriteLine($"'{pair.Key}': {pair.Value} martta");
}
