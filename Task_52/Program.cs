// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 1, 50);
PrintArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцам
{
    Write($"{GetAverage(matrix, j):f2} ");
}

double GetAverage(int [,] inArray, int col)
{
    double sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++) // перебираем строки заданного столбца
    {
        sum += inArray[i, col];
    }

    return sum / inArray.GetLength(0);
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

