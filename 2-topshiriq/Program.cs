using System;

// 1-masala
string inputValue = Console.ReadLine();
int allMinut = Convert.ToInt32(inputValue);
int hour = allMinut / 60;
int minut = allMinut % 60;
Console.WriteLine($"{hour}:{minut}");

// 2-masala
string inputValue = Console.ReadLine();
int yosh = Convert.ToInt32(inputValue);
if(yosh > 0 && yosh <= 12){
    Console.Write("bola");
}
else if(yosh > 12 && yosh <= 19){
    Console.Write("o'smir");
}
else if(yosh > 19 && yosh <= 59){
    Console.Write("kattalar");
}
else{
    Console.Write("katta");
}

// 3-masala
Console.Write("Birinchi fan: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikkinchi fan: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Uchingchi fan: ");
int third = Convert.ToInt32(Console.ReadLine());

float ball = (first+second+third) / 3.0f;

string grade = ball >= 80 
    ? "A'lo"
    : ball >= 60
        ? "Yaxshi"
        : ball >= 40
            ? "Qoniqarli"
            : "Qoniqarsiz";
Console.WriteLine(grade);


// 4-masala
Random random = new Random();
int randomNumber = random.Next(1, 101);

while (1 == 1){
    Console.Write("Raqamni taxmin qiling: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string message = number > randomNumber
        ? "Siz kiritgan raqam katta"
        : number == randomNumber
            ? "Topdingiz"
            : "Siz kiritgan raqam kichik";
    Console.WriteLine(message);
    if(message == "Topdingiz"){
        break;
    }
}
