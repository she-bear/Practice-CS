// Задать двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 1, 10);
PrintArray(matrix);

WriteLine();
ChangeRows(matrix);
PrintArray(matrix);

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

void ChangeRows(int[,] inArray)
{
    int rowCount = inArray.GetLength(0) - 1;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[0, i];
        inArray[0, i] = inArray[rowCount, i];
        inArray[rowCount, i] = k;
    }
}
