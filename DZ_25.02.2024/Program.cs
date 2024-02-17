
//Записал все в одном файле, чтобы не плодить проекты. Класс - номер задание. 
class Task1
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100");
        }
        else
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
/*class Task2
{
    static void Main()
    {
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите процент: ");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (percent / 100) * number;

        Console.WriteLine($"Результат: {result}");
    }
}*/
/*class Task3
{
    static void Main()
    {
        Console.WriteLine("Введите четыре цифры:");

        int[] digits = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Введите {i + 1}-ю цифру: ");
            digits[i] = Convert.ToInt32(Console.ReadLine());
        }

        int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

        Console.WriteLine($"Число, сформированное из введенных цифр: {number}");
    }
}*/
/*class Task4
{
    static void Main()
    {
        Console.Write("Введите шестизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100000 || number > 999999)
        {
            Console.WriteLine("Ошибка: Введено число не являющееся шестизначным");
            return;
        }

        Console.Write("Введите номера разрядов для обмена (например, 1 и 6): ");
        string[] positions = Console.ReadLine().Split(' ');
        int position1 = Convert.ToInt32(positions[0]);
        int position2 = Convert.ToInt32(positions[1]);

        if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
        {
            Console.WriteLine("Ошибка: Некорректные номера разрядов для обмена");
            return;
        }

        int[] digits = new int[6];
        int temp = number;

        for (int i = 5; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp = temp / 10;
        }

        int tempDigit = digits[position1 - 1];
        digits[position1 - 1] = digits[position2 - 1];
        digits[position2 - 1] = tempDigit;

        int newNumber = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];

        Console.WriteLine($"Новое число после обмена цифр: {newNumber}");
    }
}*/
/*class Task5
{
    static void Main()
    {
        Console.Write("Введите дату в формате ДД.ММ.ГГГГ: ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        string season = GetSeason(date.Month);
        string dayOfWeek = date.DayOfWeek.ToString();

        Console.WriteLine($"{season} {dayOfWeek}");
    }

    static string GetSeason(int month)
    {
        if (month == 12 || month <= 2)
        {
            return "Winter";
        }
        else if (month >= 3 && month <= 5)
        {
            return "Spring";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Summer";
        }
        else
        {
            return "Autumn";
        }
    }
}*/
/*class Task6
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Перевести температуру из Фаренгейта в Цельсий");
        Console.WriteLine("2. Перевести температуру из Цельсия в Фаренгейт");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Температура в градусах Цельсия: {celsius}");
        }
        else if (choice == 2)
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректный выбор действия.");
        }
    }
}*/
/*class Task7
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);

        Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/