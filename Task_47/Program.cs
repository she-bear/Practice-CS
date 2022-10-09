// Задать двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

double [,] matrix = GetFloatRandomArray(rows, cols, -100, 100);
PrintArray(matrix);


void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // по столбцам
        {
            Console.Write($"{matr[i, j]:f2} ");
        }

        Console.WriteLine();
    }
}

double[,] GetFloatRandomArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)/10.0);
            Random random = new Random();
            
            result[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
        }    
    }

    return result;
}

