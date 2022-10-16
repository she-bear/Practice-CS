// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using System;
using static System.Console;

Clear();
Write("Задайте число строк: ");
int rows = int.Parse(ReadLine());
Write("Задайте число столбцов: ");
int cols = int.Parse(ReadLine());

int [,] matrix = GetRandomArray(rows, cols, 10, 99);
PrintArray(matrix);
WriteLine();

int[,] position = new int[1,2];
position = GetPosition(matrix, position);

int[,] smallMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
DeleteLines(matrix, position, smallMatrix);
WriteLine();
PrintArray(smallMatrix);


int[,] GetPosition(int[,] inArray, int[,] pos)
{
  int temp = inArray[0, 0];
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      if (inArray[i, j] <= temp)
      {
        pos[0, 0] = i;
        pos[0, 1] = j;
        temp = inArray[i, j];
      }
    }
  }
  
  Console.WriteLine($"Mинимальный элемент: {temp}");
  return pos;
}

void DeleteLines(int[,] inArray, int[,] pos, int[,] smallArray)
{
  int k = 0, l = 0;
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      if (pos[0, 0] != i && pos[0, 1] != j)
      {
        smallArray[k, l] = inArray[i, j];
        l++;
      }
    }
    l = 0;
    if (pos[0, 0] != i)
    {
      k++;
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