// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные (нумерация с 1), и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 1, 10);
PrintArray(matrix);
int [,] matrix_sqrt = GetArray(matrix);
WriteLine();
PrintArray(matrix_sqrt);


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

int[,] GetArray(int [,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (((i+1)%2 == 0) && ((j+1)%2 == 0)) // (i > 0 && i % 2 == 1 && j > 0 && j % 2 == 1)
            {
                result[i, j] = inArray[i, j] * inArray[i, j];
            }    
            else
                result[i, j] = inArray[i, j];
        }    
    }

    return result;
}


