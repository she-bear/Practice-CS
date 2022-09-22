// выводит третью цифру заданного числа или сообщает, что третьей цифры нет: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    
    Console.WriteLine($"{number % 10}");
} else
{
    Console.WriteLine($"Третьей цифры нет...");
}
