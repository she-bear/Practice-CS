// квадрат числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.Write($"Квадрат числа {number} равняется {sqr}");
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.Write($" Квадрат числа {number} равняется {sqr1}");