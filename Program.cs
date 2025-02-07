/*using System;

class Program
{
    static void Main()
    {
        int sum = 0; // Yig'indini saqlash uchun o'zgaruvchi
        int i = 1;   // Boshlang'ich qiymat

        while (i <= 1000)
        {
            if (i % 2 != 0) // Toq sonligini tekshirish
            {
                sum += i; // Toq sonni yig'indiga qo'shish
            }
            i++; // Keyingi son uchun i ni oshirish
        }

        Console.WriteLine("1 dan 1000 gacha bo'lgan toq sonlarning yig'indisi: " + sum);
    }
}







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
        int max = array[0]; // Eng katta qiymatni topish uchun boshlang'ich qiymat

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
*/