// Последняя цифра трехзначного числа: 345 -> 5, 890 -> 0
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = number % 10;

Console.WriteLine($"{result}");
