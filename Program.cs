using System;

string inputNumber = Console.ReadLine();
int number = Convert.ToInt32(inputNumber);

string str = "teLefOn";
int length = str.Length;
if(length < number){
    Console.WriteLine(str.ToUpper());
}
else{
    Console.WriteLine(str.ToLower());
}


// 2 masala

int x = 15;
int y = 10;

string result;
if (x > y)
{
    result = "x is greater than y";
}
else if (x < y)
{
    result = "x is less than y";
}
else if (x == y)
{
    result = "x is equal to y";
}
else
{
    result = "x and y are not comparable";
}

Console.WriteLine(result);



// 3 masala

string uzbekDayName = Console.ReadLine();
string englishDayName = uzbekDayName switch
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
    _ => "Hafta kuni aniqlanmadi"
};
Console.WriteLine(englishDayName);

