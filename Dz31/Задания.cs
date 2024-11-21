using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public enum Day
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятнциа,
    Суббота,
    Воскресенье
}

public partial class Programm
{
    static void Starttask(byte n)
    {
        Console.WriteLine($"Задание: {n}");
    }

    static void Task1()
    {
        Starttask(1);

        // Массив для чисел
        int[] nums = new int[10];

        Console.WriteLine($"Введите число от {int.MinValue} до {int.MaxValue}\r\nПосле ввод нажмите 'Enter' и введите новое число");

        for (int i11 = 0; i11 < nums.Length; i11++)
        {
            nums[i11] = int.Parse(Console.ReadLine());
        }

        // Введём значение, для начала сравнения
        int znach = nums[0];

        for (int i12 = 0; i12 < nums.Length; i12++)
        {
            if (i12 == 0)
            {
                continue;
            }
            else if (nums[i12] > znach)
            {
                znach = nums[i12];
                continue;
            }
            else
            {
                Console.WriteLine($"Число под номером {i12 + 1} нарушает возрастающую последовательнось!");
                break;
            }
        }
    }

    static void Task2()
    {
        Starttask(2);

        string[] cards = new string[]
        {
            "Шесёрка",
            "Семёрка",
            "Восьмёрка",
            "Девятка",
            "Десятка",
            "Валет",
            "Дама",
            "Король",
            "Туз"
        };

        try
        {
            Console.WriteLine("Введите пожалуйста число 6 - 14");
            byte card = byte.Parse(Console.ReadLine());

            if (card > 5 && card < 15)
            {
                card -= 6;
                Console.WriteLine($"Ваша карта: {cards[card]}");
            }
            else { Console.WriteLine("Вы ввели число, не принадлежащее промежутку 6 - 14"); }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число! Пожалуйста, в следующий раз введите число 6 - 14");
        }
    }

    static void Task3()
    {
        Starttask(3);

        // Создадим два массива для напитков и посетителей
        string[] alcoinput = new string[]
        {
            "Jabroni",
            "SCounselor",
            "Programmer",
            "BGM",
            "Politician",
            "Rapper"
        };
        string[] alcooutput = new string[]
        {
            "Patron Tequila",
            "Anything with Alcohol",
            "Hipster Craft Beer",
            "Moonshine",
            "Your tax dollars",
            "Cristal",
            "Beer"
        };

        Console.WriteLine("Введите социальный статус посетителя и узнайте его самый любимый напиток!");
        string drink = Console.ReadLine();

        for (int i3 = 0; i3 < alcoinput.Length; i3++)
        {
            if (alcoinput[i3].Contains(drink, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ДА, он у нас! Он любит пить {alcooutput[i3]}.");
                break;
            }
            else if (i3 == alcoinput.Length - 1)
            {
                Console.WriteLine("Простите, но у нас нет такого покупателя...");
            }
        }
    }

    static void Task4()
    {
        Starttask(4);

        try
        {
            Console.WriteLine("Ввидете день недели:");
            byte day = byte.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                // Введём переменную, которая будет забирать из перечисления названия дня по его индексу
                Day dayofweek = (Day)day - 1;


                Console.WriteLine($"Сегодня {dayofweek}!");
            }
            else
            {
                Console.WriteLine("Вы ввели число, которое не является днём недели!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число!");
        }
        finally
        {
            Console.WriteLine("Спасибо за попытку!");
        }
    }

    static void Task5()
    {
        Starttask(5);

        Console.WriteLine("Введите кол-во кукол, которые вы хотели, чтобы мы рассмотрели на добавление в нашу книгу!");
        byte quan = byte.Parse(Console.ReadLine());

        // Создадим список для добавления в него кукол
        List<string> dolls = new List<string>();

        Console.WriteLine("Введите пожалуйста названия кукол!");

        for (int i51 = 0; i51 < quan; i51++)
        {
            string doll = Console.ReadLine();
            dolls.Add(doll);
        }

        byte countdoll = 0;

        foreach (string i52 in dolls)
        {
            if ((i52.Contains("Hello Kitty", StringComparison.OrdinalIgnoreCase)) || (i52.Contains("Barbie doll", StringComparison.OrdinalIgnoreCase)))
            {
                countdoll++;
            }
        }

        Console.WriteLine($"Мы добавили в книгу {countdoll} ваших кукол!");
    }
    public static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }
}
