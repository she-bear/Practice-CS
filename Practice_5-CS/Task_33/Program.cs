// Присутствует ли заданное число в массиве: 4,  [6, 7, 19, 345, 3] -> нет, 3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


// случайное заполнение
int[] array = GetRandomArray(10, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(GetNumber(number, array));

// ввод с клавиатуры
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

if (FindElement(baseArray, number))
{
    Console.WriteLine("Да");
} else
{
    Console.WriteLine("Нет");
}

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

bool FindElement(int[] array, int el)
{
    foreach (int item in array)
    {
        if (el == item) return true;
    }
    return false;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

bool GetNumber (int num, int[] collection)
{
    foreach (int element in collection)
    {
        if (element == num)
        {
            return true;
        }
    }

    return false;
}
