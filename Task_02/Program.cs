// Поиск максимального из двух чисел: a = 5; b = 7 -> max = 7

Console.Clear();
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 == number_2)
{
    Console.Write("Числа равны!");
    return;
}

if (number_1 > number_2)
{
    Console.Write($"Max = {number_1}");
}
else
{
   Console.Write($"Max = {number_2}");
}