// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 1, 10);
PrintArray(matrix);
WriteLine(GetSumDiagonal(matrix));


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

int GetSumDiagonal(int [,] inArray)
{ 
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += inArray[i, j];
            }    
        }    
    }

    return sum;
}
