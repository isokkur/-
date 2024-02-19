using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int number2 = int.Parse(Console.ReadLine());

                if (number2 == 0)
                {
                    throw new DivideByZeroException();
                }

                int result = number1 / number2;
                Console.WriteLine($"Результат деления: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                continue;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число!");
                continue;
            }
            finally
            {
                Console.WriteLine("Следующая итерация");
            }
        }
    }
}