// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    SortRow(matrix, i);    
}

PrintArray(matrix);


void SortRow(int[,] inArray, int row)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = i+1; j < inArray.GetLength(1); j++)
        {
            if (inArray[row, i] < inArray[row,j])
            {
                int temp = inArray[row,i];
                inArray[row,i] = inArray[row,j];
                inArray[row,j]= temp;
            }
        }
    }
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
