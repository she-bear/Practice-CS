// вывод массива из 8 элементов, заполненного нулями и единицами в случайном порядке
int[] array = new int[8];
FillArray(array);
PrintArray(array);

// другое решение
int [] array_2 = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] GetArray (int size) {
    int [] arr = new int [size];
    for (int i = 0; size < i; i++)
    {
        arr[i] = new Random().Next(2);
    }

    return arr;
}


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
