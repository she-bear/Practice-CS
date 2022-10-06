// является ли одно число квадратом второго
Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1 == number2)
{
    Console.WriteLine("Второе число квадрат первого");
}
// Math.Pow(number2, 2)
else if (number2*number2 == number1)
    {
       Console.WriteLine("Первое число квадрат второго"); 
    }
    else
    {
        Console.WriteLine("Не квадраты"); 
    }