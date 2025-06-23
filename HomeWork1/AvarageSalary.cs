using System;
using System.Text;
internal class AverageSalary
{
    static void CalculateAverageSalary()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть кількість працівників:");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        decimal totalSalary = 0;
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Введіть зарплату працівника {i + 1}:");
            decimal salary = decimal.Parse(Console.ReadLine());
            totalSalary += salary;
        }
        decimal averageSalary = totalSalary / numberOfEmployees;
        Console.WriteLine($"Середній заробіток: {averageSalary:C}");
    }
}
