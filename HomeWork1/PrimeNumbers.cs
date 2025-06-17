using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class PrimeNumbers
    {
       public PrimeNumbers() { }
        public void PrintPrimes(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число до якого потрібно знайти прості числа:");
            int limit = int.Parse(Console.ReadLine());
            for (int num = 2; num <= limit; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }

        }

    }
}
