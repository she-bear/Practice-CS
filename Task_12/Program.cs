// принимает на вход два числа и выводит, является ли второе кратным первому
// если второе число не кратно первому, то программа выводит остаток от деления: 34, 5 -> не кратно, остаток 4
// 16,4 -> кратно 

Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Второе число кратно первому");
} else
{
    Console.WriteLine ($"Не кратно, остаток от деления: {number1 % number2}");
}