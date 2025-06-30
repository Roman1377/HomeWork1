using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class ListOfActivity
    {
        public ListOfActivity() { }
        public void PrintActivities()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("Звіт подій");
            report.AppendLine($"Дата: {DateTime.Now.ToShortDateString()}");
            report.AppendLine("Список подій:");
            List<string> events = new List<string>();
            string input;
            Console.WriteLine("Введіть події (для завершення введіть 'exit'):");

            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                events.Add(input);
            }
            foreach (var ev in events)
            {
                report.AppendLine($"- {ev}");
            }
            Console.WriteLine(report.ToString());

        }
    }
}