// Переворот одномерного массива: [1 2 3 4 5] -> [5 4 3 2 1]

Console.Clear();

int[] array = GetRandomArray(10, 0, 10);
Console.WriteLine($"[{String.Join(",", array)}]");

// меняем вспомогательный массив
int[] ReverseArray = ReverseArray_2(array);
Console.WriteLine($"[{String.Join(",", ReverseArray)}]");

// меняем исходный массив
ReverseArray_1(array);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// через временную переменную
void ReverseArray_1 (int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

// через вспомогательный массив
int[] ReverseArray_2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}