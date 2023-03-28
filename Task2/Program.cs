
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Random rnd = new Random();
int[,] array = GetArray(4, 3, 1, 9);
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return Array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("  ");
    }
}
PrintArray(array);

void GetLowRows(int[,] array)
{
    int minsum = 0;
    int result = 0;
    int minRows = 0;
    for (int k = 0; k < array.GetLength(0) - 1; k++)
    {
        result += array[0, k];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            minsum += array[i, j];

        }

        Console.WriteLine($"Значение первой строки равно : {minsum} ");

        if (minsum < result)

        {
            result = minsum;
            minRows = i;
        }
        minsum = 0;
    }

    Console.WriteLine($"минимальное значение = {result} , cтрока {minRows + 1}");
}

GetLowRows(array); 