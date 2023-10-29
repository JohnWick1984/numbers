using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 100: ");
        string input = Console.ReadLine();
        int number = 0;

        if (input.Length > 0 && input.Length < 4)
        {
            bool isNumber = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    isNumber = false;
                    break;
                }
            }

            if (isNumber)
            {
                number = int.Parse(input);

                if (number >= 1 && number <= 100)
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
                else
                {
                    Console.WriteLine("Ошибка: число вне диапазона от 1 до 100");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное число");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное число");
        }
    }
}
