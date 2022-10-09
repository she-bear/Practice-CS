// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetArray(rows, cols);
PrintArray(matrix);


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

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }    
    }

    return result;
}

