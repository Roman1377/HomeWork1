using System;
using System.Linq;
Console.OutputEncoding = System.Text.Encoding.UTF8;

#region 1

int[] array = new int[10];

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11); // Від -10 до 10 включно
}

for (int i = 0; i < array.Length; i += 2)
{
    Console.WriteLine($"Елемент з парним індексом {i}: {array[i]}");
}

#endregion

#region 2

bool isSumNonNegative = true;
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
isSumNonNegative = sum >= 0;
Console.WriteLine($"Сума елементів масиву: {sum}. Чи є вона невід'ємною? {isSumNonNegative}");

#endregion 

#region 3

int[,] multiplicationTable = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write($"{multiplicationTable[i, j],3} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

#endregion

#region 4

int[,] array2D = new int[5, 5];

Random random2D = new Random();
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = random2D.Next(1, 101); // Від 1 до 100 включно
    }
}

int maxElement = array2D[0, 0];
int minElement = array2D[0, 0];
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (array2D[i, j] > maxElement)
        {
            maxElement = array2D[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (array2D[i, j] < minElement)
        {
            minElement = array2D[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
Console.WriteLine($"Максимальний елемент: {maxElement} на позиції ({maxRow}, {maxCol})");
Console.WriteLine($"Мінімальний елемент: {minElement} на позиції ({minRow}, {minCol})");

#endregion

#region 5

Console.Write("Введіть кількість днів: ");

int days;

while (!int.TryParse(Console.ReadLine(), out days) || days < 0)
{
    Console.Write("Будь ласка, введіть невід'ємне число: ");
}
int currentDayIndex = (int)DayOfWeek.Monday; // Починаємо з понеділка
int resultDayIndex = (currentDayIndex + days) % 7; // Обчислюємо день тижня
Console.WriteLine($"День тижня через {days} днів: {((DayOfWeek)resultDayIndex)}");

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

#endregion