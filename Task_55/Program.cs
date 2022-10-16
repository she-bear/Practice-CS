// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Если новый массив не создается, то решение возможно только для квадратного массива

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

if (rows != cols)
{
    WriteLine("В данной матрице нельзя заменить элементы!");
    return;
}

int [,] matrix = GetRandomArray(rows, cols, 1, 10);
PrintArray(matrix);
PrintArray(ChangeArray1(matrix));
WriteLine();
PrintArray(matrix);
WriteLine();
ChangeArray2(matrix);
WriteLine();
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

// это решение подходит и для прямоугольной матрицы
int[,] ChangeArray1(int[,] array)
{
    int[,] result = new int [array.GetLength(1), array.GetLength(0)]; // новый массив с, возможно, другой размерностью
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];  // просто меняем местами индексы
        }
    }
    return result;
}

// решение через временную переменную
void ChangeArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int k = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = k;
        }
    }
}

