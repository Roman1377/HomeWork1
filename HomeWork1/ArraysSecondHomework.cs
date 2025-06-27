using System;
using System.Collections.Generic;
using System.Linq;

internal class ArraysSecondHomework
{
    static void Main(string[] args)
{ 
int[,] arrays = {
    {4, 1, 6, 7, 32, 14, 17, 45},
    {2, 4, 1, 5, 22, 10, 13, 33},
};

#region Знаходження другого найбільшого елемента масиву

for (int j = 0; j < arrays.GetLength(0); j++)
{
    int[] array = new int[arrays.GetLength(1)];

     for (int i = 0; i < arrays.GetLength(1); i++)
    {
        array[i] = arrays[j, i];
    }
    Array.Sort(array);
    int secondLargest = array[array.Length - 2];
    Console.WriteLine($"Другий найбільший елемент масиву {j + 1}: {secondLargest}");
}
#endregion

#region Сортування елементів двовимірного масиву за зростанням

for (int j = 0; j < arrays.GetLength(0); j++)
{
    int[] array = new int[arrays.GetLength(1)];
        for (int i = 0; i < arrays.GetLength(1); i++)
    {
        array[i] = arrays[j, i];
    }
    Array.Sort(array);
    Console.WriteLine($"Відсортований масив {j + 1}: {string.Join(", ", array)}");
}
#endregion

#region Видалення елемента з масиву за вказаним індексом

for (int j = 0; j < arrays.GetLength(0); j++)
{
    int[] array = new int[arrays.GetLength(1)];
    for (int i = 0; i < arrays.GetLength(1); i++)
    {
        array[i] = arrays[j, i];
    }

    Console.Write("Введіть індекс для видалення елемента: ");
    int indexToRemove = int.Parse(Console.ReadLine() ?? "0");

    if (indexToRemove >= 0 && indexToRemove < array.Length)
    {
        List<int> list = array.ToList();
        list.RemoveAt(indexToRemove);
        array = list.ToArray();
        Console.WriteLine($"Масив після видалення елемента з індексом {indexToRemove}: {string.Join(", ", array)}");
    }
    else
    {
        Console.WriteLine("Невірний індекс.");
    }
}

#endregion

#region Знаходження суми елементів по діагоналі у двовимірному масиві. Зробив усіх по приколу =)

int columns = arrays.GetLength(1);

int[] sumArray = new int[columns - 1];

for (int i = 0; i < columns - 1; i++)
{
    sumArray[i] = arrays[0, i] + arrays[1, i + 1];
}

Console.WriteLine("Сума діагональних пар масиву");
Console.WriteLine($"{string.Join(", ", sumArray)}");
#endregion
        }
}