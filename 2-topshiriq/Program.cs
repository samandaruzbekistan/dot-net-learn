using System;
using System.Collections.Generic;

static List<string> tasks = new List<string>();  
static List<bool> taskStatus = new List<bool>(); 
int choice = 0;

while (choice != 4)
{
    Console.WriteLine("\nVazifa menejeri:");
    Console.WriteLine("1. Vazifa qo'shish");
    Console.WriteLine("2. Vazifani o'chirish");
    Console.WriteLine("3. Vazifani bajarildi deb belgilash");
    Console.WriteLine("4. Dasturni yakunlash");
    Console.WriteLine("Hozirgi vazifalar ro'yxati:");
    ShowTasks(); // Vazifalar ro'yxatini chiqarish
    Console.Write("Tanlovingizni kiriting (1-4): ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddTask();
            break;
        case 2:
            DeleteTask();
            break;
        case 3:
            MarkTaskAsDone();
            break;
        case 4:
            Console.WriteLine("Dasturni yakunlamoqdasiz...");
            break;
        default:
            Console.WriteLine("Noto'g'ri tanlov! Iltimos, qaytadan urinib ko'ring.");
            break;
    }
}

static void AddTask()
{
    Console.Write("Vazifa kiriting: ");
    string task = Console.ReadLine();
    tasks.Add(task);          // Vazifani qo'shish
    taskStatus.Add(false);    // Bajarilgan deb belgilanmagan (false)
    Console.WriteLine($"'{task}' vazifasi qo'shildi.");
}

static void DeleteTask()
{
    Console.Write("Qaysi vazifani o'chirmoqchisiz (raqamini kiriting): ");
    int index = int.Parse(Console.ReadLine());

    if (index >= 0 && index < tasks.Count)
    {
        Console.WriteLine($"'{tasks[index]}' vazifasi o'chirildi.");
        tasks.RemoveAt(index);         // Tanlangan vazifani o'chirish
        taskStatus.RemoveAt(index);    // Uning holatini ham o'chirish
    }
    else
    {
        Console.WriteLine("Noto'g'ri raqam kiritildi.");
    }
}

static void MarkTaskAsDone()
{
    Console.Write("Qaysi vazifani bajarildi deb belgilamoqchisiz (raqamini kiriting): ");
    int index = int.Parse(Console.ReadLine());

    if (index >= 0 && index < tasks.Count)
    {
        taskStatus[index] = true; // Bajarilganlikni belgilash
        Console.WriteLine($"'{tasks[index]}' bajarildi deb belgilandi.");
    }
    else
    {
        Console.WriteLine("Noto'g'ri raqam kiritildi.");
    }
}

static void ShowTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Vazifalar mavjud emas.");
    }
    else
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = taskStatus[i] ? "Bajarilgan" : "Bajarilmagan";
            Console.WriteLine($"{i}. {tasks[i]} [{status}]");
        }
    }
}
