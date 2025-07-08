using System;

namespace HomeWork1
{
    public static class FibonacciCalculator
    {
        // Рекурсивна функція для обчислення n-го числа Фібоначчі
        public static int GetFibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть номер числа Фібоначчі:");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int result = FibonacciCalculator.GetFibonacci(n);
                Console.WriteLine($"Число Фібоначчі під номером {n} дорівнює {result}");
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне невід'ємне ціле число.");
            }
        }
    }
}
