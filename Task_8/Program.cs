﻿// Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count},");
    }
    count++;
}
