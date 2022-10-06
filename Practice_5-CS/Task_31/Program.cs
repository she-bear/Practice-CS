// Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найти сумму отрицательных и положительных элементов массива.

// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(GetSumPositive(array));
Console.WriteLine(GetSumNegative(array));


int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    positiveSum += element > 0 ? element : 0;
    negativeSum += element < 0 ? element : 0;        
}

/*for (int i = 0; i < array.Length; i++) {
    int element = array[i];
    if (element > 0)
        positiveSum += element;
    else
        positiveSum += 0;
    
    negativeSum += element < 0 ? element : 0;     
} */

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int GetSumPositive (int [] collection)
{
    int count = collection.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        if (collection[i] > 0)
        {
            sum = sum + collection[i];
        }
    }

    return sum;
}

int GetSumNegative (int [] collection)
{
    int count = collection.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        if (collection[i] < 0)
        {
            sum = sum + collection[i];
        }
    }

    return sum;
}
