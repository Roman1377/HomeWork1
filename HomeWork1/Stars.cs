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
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
