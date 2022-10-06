// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1, [1, 2, 3, 6, 2] -> 0

Console.Clear();
// случайное заполнение
int[] array = GetRandomArray(20, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(GetCount(array));



int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int GetCount (int[] collection)
{
    int count = 0;
    
    foreach (int element in collection)
    {
        if ((element >= 10) && (element <= 99))
        {
            count++;
        }
    }

    return count;
}