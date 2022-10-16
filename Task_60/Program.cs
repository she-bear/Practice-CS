// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

Clear();
Write("Ведите размерность массива: ");
int size = int.Parse(ReadLine());
int [,,] CubeArray = GetCubeArray(size, 10, 99);
PrintArray(CubeArray);


int[,,] GetCubeArray(int size, int minValue, int maxValue)
{
  int[,,] result = new int [size, size, size];
  
  // временный массив неповторяющихся чисел
  int[] tempArray = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)];
  int number;
  
  for (int i = 0; i < tempArray.GetLength(0); i++)
  {
    tempArray[i] = new Random().Next(minValue, maxValue + 1);
    number = tempArray[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tempArray[i] == tempArray[j])
        {
          tempArray[i] = new Random().Next(minValue, maxValue + 1);
          j = 0;
          number = tempArray[i];
        }
          number = tempArray[i];
      }
    }
  }
  
  int count = 0; 
  for (int x = 0; x < result.GetLength(0); x++)
  {
    for (int y = 0; y < result.GetLength(1); y++)
    {
      for (int z = 0; z < result.GetLength(2); z++)
      {
        result[x, y, z] = tempArray[count];
        count++;
      }
    }
  }

  return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}