// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов, не равное числу строк: ");
int cols = int.Parse(ReadLine());

if (rows == cols)
{
    WriteLine("Задан не прямоугольный массив!");
    return;
}

int [,] matrix = GetRandomArray(rows, cols, 1, 10);
PrintArray(matrix);
WriteLine();
WriteLine($"{GetMinSumRow(matrix)} строка (строки считаем с 0)");


int GetMinSumRow (int [,] inArray)
{
    int MinSum = 0;
    int MinRow = 0;
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int CurrentSum = 0;

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            CurrentSum += inArray[i, j];
        }

        if (i == 0) // инициализируем минимальную сумму
        {
            MinSum = CurrentSum;
            MinRow = 0;
        }

        if (CurrentSum < MinSum)
        {
            MinSum = CurrentSum;
            MinRow = i;
        }
    }

    return MinRow;
}


int[,] GetRandomArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }    
    }

    return result;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // по столбцам
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}