// вывод массива из 8 элементов
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int array_length = int.Parse(Console.ReadLine());

// способ с random и String.Join
int [] array = FillArrayRandom(array_length);
Console.WriteLine($"[{String.Join(",", array)}]");

// способ с вводом с клавиатуры и выводом через метод
int [] array_2 = FillArrayFromKeyboard(array_length);
PrintArray(array_2);


int [] FillArrayRandom (int size) {
    int [] collection = new int [size];

    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(0, 101);
        index++;
    }
    
    return collection;
}

int [] FillArrayFromKeyboard (int size) {
    int [] collection = new int [size];

    int index = 0;
    while (index < size)
    {
        Console.Write($"Введите {index}-й элемент массива: ");
        collection[index] = int.Parse(Console.ReadLine());
        index++;
    }
    
    return collection;
}


void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
}

