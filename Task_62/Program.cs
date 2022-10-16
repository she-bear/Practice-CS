// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] matrix = GetSpiralArray(4);
PrintArray(matrix);


int [,] GetSpiralArray(int size)
{
    int[,] result = new int[size, size];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    return result;
}


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // по столбцам
        {
            if (matr[i,j] < 10)
                Console.Write($"0{matr[i,j]} ");

            else Console.Write($"{matr[i,j]} ");
        }

        Console.WriteLine();
    }
}