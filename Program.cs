/*
 Basic takrorlash bolimi boyicha 2 chi amaliy vazifa

using System;
using System.Collections.Generic;

public class TaskItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<TaskItem> tasks = new List<TaskItem>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nVazifa Menejeri");
            Console.WriteLine("1. Vazifa qo'shish");
            Console.WriteLine("2. Vazifani o'chirish");
            Console.WriteLine("3. Vazifani bajarilgan deb belgilash");
            Console.WriteLine("4. Barcha vazifalarni ko'rsatish");
            Console.WriteLine("5. Dasturdan chiqish");
            Console.Write("Tanlang: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Vazifa tavsifini kiriting: ");
                    string desc = Console.ReadLine();
                    tasks.Add(new TaskItem { Description = desc, IsCompleted = false });
                    Console.WriteLine("Vazifa qo'shildi.");
                    break;
                case "2":
                    Console.WriteLine("O'chirish uchun vazifani tanlang:");
                    if (DisplayTasks(tasks))
                    {
                        Console.Write("O'chirish uchun vazifa raqamini kiriting: ");
                        string inputDelete = Console.ReadLine();
                        if (int.TryParse(inputDelete, out int taskNumber))
                        {
                            int index = taskNumber - 1;
                            if (index >= 0 && index < tasks.Count)
                            {
                                tasks.RemoveAt(index);
                                Console.WriteLine("Vazifa o'chirildi.");
                            }
                            else
                            {
                                Console.WriteLine("Noto'g'ri raqam.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri kiritish.");
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Bajarilgan deb belgilash uchun vazifani tanlang:");
                    if (DisplayTasks(tasks))
                    {
                        Console.Write("Vazifa raqamini kiriting: ");
                        string inputMark = Console.ReadLine();
                        if (int.TryParse(inputMark, out int taskNumber))
                        {
                            int index = taskNumber - 1;
                            if (index >= 0 && index < tasks.Count)
                            {
                                tasks[index].IsCompleted = true;
                                Console.WriteLine("Vazifa bajarilgan deb belgilandi.");
                            }
                            else
                            {
                                Console.WriteLine("Noto'g'ri raqam.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri kiritish.");
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Barcha vazifalar:");
                    DisplayTasks(tasks);
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Noto'g'ri tanlov.");
                    break;
            }
        }
    }

    static bool DisplayTasks(List<TaskItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Vazifalar mavjud emas.");
            return false;
        }
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tasks[i].IsCompleted ? "[Bajarildi]" : "[Kutilmoqda]";
            Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
        }
        return true;
    }
}



 Basic takrorlash bolimi boyicha 1 chi amaliy vazifa

1-vazifa
using System;


class Program

{

    static void Main()

    {

        int sum = 0; // Yig'indini saqlash uchun o'zgaruvchi

        int i = 1;   // Boshlang'ich qiymat


        while (i <= 1000)

        {

            if (i % 2 != 0) // Toq sonligini tekshirish

            {

                sum += i; // Toq sonni yig'indiga qo'shish

            }

            i++; // Keyingi son uchun i ni oshirish

        }

2-vazifa

using System;


class Program

{

    static void Main()

    {

        int[] array = { 5, 12, 7, 3, 9, 15 }; // Misol uchun array


        if (array.Length == 0)

        {

            Console.WriteLine("Array bo'sh!");

            return;

        }


        int min = array[0]; // Eng kichik qiymatni topish uchun boshlang'ich qiymat

        int max = array[1]; // Eng katta qiymatni topish uchun boshlang'ich qiymat


        for (int i = 0; i < array.Length; i++)

        {

            if (array[i] < min)

            {

                min = array[i]; // Eng kichik qiymatni yangilash

            }

            if (array[i] > max)

            {

                max = array[i]; // Eng katta qiymatni yangilash

            }

        }


        int product = min * max; // Ko'paytma hisoblash

        Console.WriteLine("Eng katta va eng kichik qiymatlarning ko'paytmasi: " + product);

    }

}

3-vazifa

using System;


class Program

{

    static void Main()

    {

        Console.Write("Butun son kiriting (x): ");

        int x = int.Parse(Console.ReadLine()); // Faktorialni hisoblash uchun son


        if (x < 0)

        {

            Console.WriteLine("Faktorial manfiy son uchun mavjud emas!");

            return;

        }


        long factorial = 1; // Faktorialni saqlash uchun o'zgaruvchi (long turidan foydalanamiz)


        for (int i = 1; i <= x; i++)

        {

            factorial *= i; // Faktorialni hisoblash

        }


        Console.WriteLine($"{x}! = {factorial}");

    }

}


        Console.WriteLine("1 dan 1000 gacha bo'lgan toq sonlarning yig'indisi: " + sum);

    }

}

*/