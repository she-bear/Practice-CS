// принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа: 456 -> 5

Console.Clear();
Console.Write("Введите трехначное число: ");
int number = int.Parse(Console.ReadLine());

// проверим на трехзначность
if ((number > 99) && (number < 1000))
{
    Console.WriteLine($"{number / 10 % 10}");
} else
{
    Console.WriteLine($"Введено не трехзначное число!");
}    
