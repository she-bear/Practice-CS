// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным: 6 -> да, 7 -> да, 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели [1..7]: ");
int day = int.Parse(Console.ReadLine());

// проверим на допустимость
if ((day > 0) && (day < 8))
{
    if ((day == 6) || (day == 7))
    {
        Console.WriteLine($"{day} -> да");    
    } else
    {
        Console.WriteLine($"{day} -> нет");    
    }
} else
{
    Console.WriteLine($"Введено недопустимое число!");
}