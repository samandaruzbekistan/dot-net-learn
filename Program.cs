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
