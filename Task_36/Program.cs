// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу случайных чисел: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу случайных чисел: ");
int maxNumber = int.Parse(Console.ReadLine());


int[] array = GetRandomArray(size, minNumber, maxNumber);
Console.WriteLine($"[{String.Join(",", array)}] -> {SumOddItems(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int SumOddItems (int [] collection)
{
    int sum = 0;
    
    for (int i = 1; i < collection.Length; i+=2)
    {
        sum += collection[i];
    }

    return sum;
}