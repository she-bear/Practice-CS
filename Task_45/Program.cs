// Создание копии заданного массива с помощью поэлементного копирования

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(size, 0, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] arrayCopy = GetArrayCopy(array);
Console.WriteLine($"[{String.Join(",", arrayCopy)}]");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] GetArrayCopy(int[] InArray)
{
    int[] ResultArray = new int[InArray.Length];
    for (int i = 0; i < InArray.Length; i++)
    {
        ResultArray[i] = InArray[i];
    }

    return ResultArray;
}