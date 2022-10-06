// 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0) {
    number = -number;
}

int count = -number;
while (count <= number)
{
    Console.Write($"{count},");
    count++;
}