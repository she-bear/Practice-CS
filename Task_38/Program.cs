// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(size, 0, 999);
Console.WriteLine($"[{String.Join(",", array)}] -> {MinMaxDifference(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int MinMaxDifference (int [] collection)
{
    int Min = collection[0];
    int Max = collection[0];

    foreach (int item in collection)
    {
        if (Min > item)
            Min = item;
        if (Max < item)
            Max = item;    
    }

    return Max - Min;
}
