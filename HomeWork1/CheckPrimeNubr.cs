using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class CheckPrimeNubr
    {
        public CheckPrimeNubr() { }
        public void CheckPrimeNumber()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число для перевірки на простоту:");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} є простим числом.");
            }
            else
            {
                Console.WriteLine($"{number} не є простим числом.");
            }
        }
    }
}
