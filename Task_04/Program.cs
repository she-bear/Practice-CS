//  Программа принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;

if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;

Console.Write($"Max = {max}");