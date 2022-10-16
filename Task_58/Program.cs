// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static System.Console;

Clear();
Write("Задайте число строк матрицы A: ");
int rowsA = int.Parse(ReadLine());
Write("Задайте число столбцов матрицы А: ");
int colsA = int.Parse(ReadLine());

int [,] matrixA = GetRandomArray(rowsA, colsA, 1, 10);
PrintArray(matrixA);
WriteLine();

Write("Задайте число строк матрицы B: ");
int rowsB = int.Parse(ReadLine());
Write("Задайте число столбцов матрицы B: ");
int colsB = int.Parse(ReadLine());

int [,] matrixB = GetRandomArray(rowsB, colsB, 1, 10);
PrintArray(matrixB);
WriteLine();

// проверяем матрицы на согласованность
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    WriteLine("Матрицы не согласованы, умножение выполнить невозможно!");
    return;
}

int [,] matrixMult = MatrixMult(matrixA, matrixB);
PrintArray(matrixMult);

int[,] MatrixMult (int[,] m, int[,] n)
{
    int[,] multMatr = new int[m.GetLength(0), n.GetLength(1)];
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < n.GetLength(1); j++)
        {
            for (int k = 0; k < n.GetLength(0); k++)
            {
                multMatr[i,j] += m[i,k] * n[k,j];
            }
        }
    }
    return multMatr;
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


