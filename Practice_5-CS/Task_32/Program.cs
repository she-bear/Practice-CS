// замена элементов массива - положительные -> отрицательные: [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] array = GetRandomArray(4, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", GetExchange(array))}]");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] GetExchange (int[] collection)
{
    for (int i=0; i < collection.Length; i++)
    {
        collection[i] *= -1;
    }

    // так работать не будет, т.к. forearch использует копию массива
    // foreach (int element in collection)
    // {
    //     element *= -1;
    // }

    return collection;
}