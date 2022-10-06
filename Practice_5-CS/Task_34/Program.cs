// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве: [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(size, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}] -> {GetCountEvenNumbers(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int GetCountEvenNumbers(int [] collection)
{
    int count = 0;
    
    foreach (int item in collection)
    {
        if (item % 2 == 0) count++;
    }

    return count;
}