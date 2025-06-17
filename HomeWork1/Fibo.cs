using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Fibo
    {
        public Fibo() { }
        public void PrintFibonacci(int n)
        {
            Console.WriteLine("Введіть кількість чисел Фібоначчі для генерації:");
            int fibonachiNumbers = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.WriteLine("Послідовність Фібоначчі:");
            for (int i = 0; i < fibonachiNumbers; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();

        }
    }
}
