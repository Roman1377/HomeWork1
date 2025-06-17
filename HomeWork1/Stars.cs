using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Stars
    {
       public Stars() { }
        public void PrintStars(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість рядків графіка:");
            int numberOfRows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
}
