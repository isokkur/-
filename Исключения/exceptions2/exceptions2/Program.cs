using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечное количество решений");
            }
            else if (a == 0)
            {
                Console.WriteLine("Уравнение не имеет решений");
            }
            else if (b % a == 0)
            {
                int x = b / a;
                Console.WriteLine($"Уравнение имеет решение: x = {x}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное число!");
        }
    }
}