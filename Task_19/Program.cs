// принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет, 12821 -> да, 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    number = -number;
}

int temp = number;
int reverse = 0;
int digit = 0;
while (temp > 0)
{
    digit = temp % 10;
    reverse = reverse * 10 + digit;
    temp = temp / 10;
}

if (number == reverse)
{
    Console.WriteLine($"{number} -> палиндром");
} else
{
    Console.WriteLine($"{number} -> нет");
}
