using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class MultiTable
    {
        public MultiTable() { }
        public void PrintMultiplicationTable(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число для множення:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Таблиця множення для числа {number}:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
