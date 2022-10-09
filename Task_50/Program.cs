// Принимает на вход позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//(1, 7) -> такого числа в массиве нет

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 0, 50);
PrintArray(matrix);

Console.Write("Введите позицию элемента через пробел (нумерация с 0): ");

string[] pos = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(pos[0]);
int col = int.Parse(pos[1]);

int res = GetItemPosition(matrix, row, col);

if (res == -1)
    WriteLine($"Такого числа в массиве нет");
else WriteLine($"{res}");   


int GetItemPosition (int [,] inArray, int m, int n)
{
    if (m > inArray.GetLength(0) - 1 || n > inArray.GetLength(1) - 1)
        return -1;
    else  return inArray[m, n];
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
