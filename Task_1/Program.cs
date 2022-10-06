// является ли второе число квадратом первого
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());

int sqr = Convert.ToInt32(Math.Pow(number_2, 2));

if (number_1 == sqr)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
