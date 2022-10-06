// Произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3, [6 7 3 6] -> 36 21

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.WriteLine($"[{String.Join(", ", GetMultArray(baseArray))}]");

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] GetMultArray(int[] collection)
{
    // int size = collection.Length / 2;
    // if (collection.Length % 2 == 1) size++;
    // вместо двух строк выше можно сделать так:
     int size = (collection.Length + 1)/ 2;

    int[] result = new int[size];

    for (int i = 0; i < collection.Length / 2; i++)
    {
        
        result[i] = collection[i] * collection[collection.Length - 1 - i];
    }
    if (collection.Length % 2 == 1) result[size-1] = collection[collection.Length / 2];
    return result;
}