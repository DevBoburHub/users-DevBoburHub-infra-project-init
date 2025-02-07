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