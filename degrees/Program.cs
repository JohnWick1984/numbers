using System;

class Program
{
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Выберите опцию (1 - Фаренгейт в Цельсий, 2 - Цельсий в Фаренгейт): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введите температуру в Фаренгейтах: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} градусов Фаренгейта равно {celsius:F2} градусов Цельсия");
        }
        else if (choice == 2)
        {
            Console.Write("Введите температуру в Цельсиях: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} градусов Цельсия равно {fahrenheit:F2} градусов Фаренгейта");
        }
        else
        {
            Console.WriteLine("Неправильный выбор опции.");
        }
    }
}
