// принимает на вход число N и выдаёт произведение чисел от 1 до N: 4 -> 24, 5 -> 120

Console.Clear();
Console.Write ("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {limit} равно {GetMult (limit)}");

int GetMult (int limit) {
    int sum = 1;
    for (int i = 1; i <= limit; i++)
        sum *= i;
    return sum;    
}
