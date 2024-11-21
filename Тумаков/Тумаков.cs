using System;


public partial class Program
{
    static void StartTask(byte n)
    {
        Console.WriteLine($"\n\nЗадание {n}");
    }
    static void Task1(ushort year, ushort daythisyear)
    {
        StartTask(1);

        // Ввод года и дня в этом году
        Console.Write("Введите год: ");
        year = ushort.Parse(Console.ReadLine());

        Console.Write("Введите день в этом году: ");
        daythisyear = ushort.Parse(Console.ReadLine());

        // Получение даты и времени
        // Добавляем дни, которые ввел пользователь, предварительно отняв один, т.к. считается,
        // что уже 1 Января!
        DateTime date = new DateTime(year, 1, 1).AddDays(daythisyear - 1);

        // Вывод полученной даты на консоль
        Console.WriteLine("Дата: {0:dd-MM-yyyy}", date);
    }

    static void Task2(string year, string daythisyear)
    {
        StartTask(2);

        ushort copyYear = 0;
        ushort copyDay = 0;

        // Ввод года и дня в этом году
        Console.Write("Введите год: ");
        year = Console.ReadLine();

        Console.Write("Введите день в этом году: ");
        daythisyear = Console.ReadLine();

        try
        {
            copyYear = ushort.Parse(year);
            copyDay = ushort.Parse(daythisyear);

            if (copyDay >= 1 && copyDay <= 365)
            {
                DateTime date = new DateTime(copyYear, 1, 1).AddDays(copyDay - 1);
                Console.WriteLine("Дата: {0:dd-MM-yyyy}", date);
            }
            else
            {
                Console.WriteLine("Вы ввели не число!!!\r\nИли число, которое не подходит!!!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число!!!\r\nИли число, которое не подходит!!!");
        }
    }
    static void Task3(string year, string daythisyear)
    {
        StartTask(3);

        ushort copyYear = 0;
        ushort copyDay = 0;

        // Ввод года и дня в этом году
        Console.Write("Введите год: ");
        year = Console.ReadLine();

        Console.Write("Введите день в этом году: ");
        daythisyear = Console.ReadLine();

        try
        {
            copyYear = ushort.Parse(year);
            copyDay = ushort.Parse(daythisyear);

            //Проверка на ВИСОКОСНЫЙ ГОД, хотя DateTime умеет работать с високосными годами
            bool flag = (copyYear % 400 == 0 || (copyYear % 4 == 0 && copyYear % 100 != 0));


            if (flag)
            {
                Console.WriteLine("Это ВИСОКОСНЫЙ год!");
            }
            else
            {
                Console.WriteLine("Это НЕ ВИСОКОСНЫЙ год!");
            }

            if (copyDay >= 1 && copyDay <= 365)
            {
                DateTime date = new DateTime(copyYear, 1, 1).AddDays(copyDay - 1);
                Console.WriteLine("Дата: {0:dd-MM-yyyy}", date);
            }
            else
            {
                Console.WriteLine("Вы ввели не число!!!\r\nИли число, которое не подходит!!!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели не число!!!\r\nИли число, которое не подходит!!!");
        }
    }
    static void Main()
    {
        string year23 = "";
        string daythisyear23 = "";
        ushort year1 = 0;
        ushort daythisyear1 = 0;

        Task1(year1, daythisyear1);
        Task2(year23, daythisyear23);
        Task3(year23, daythisyear23);
    }
}
