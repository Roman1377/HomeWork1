using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class DailyWage
    {
        public DailyWage() { }
        public void CalculateDailyWage()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість робочих годин:");
            int hoursWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть погодинну ставку:");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());
            decimal dailyWage = hoursWorked * hourlyRate;
            Console.WriteLine($"Щоденна заробітна плата: {dailyWage:C}");
        }
    }
}
