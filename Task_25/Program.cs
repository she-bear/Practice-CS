// принимает на вход два числа (A и B) и возводит число A в натуральную степень B: 3, 5 -> 243, 2, 4 -> 16

Console.Clear();
Console.Write ("Введите число A: ");
int number_A = int.Parse(Console.ReadLine());
Console.Write ("Введите число B: ");
int number_B = int.Parse(Console.ReadLine());

Console.WriteLine($"{number_A} в степени {number_B} (цикл) -> {GetDegreeCycle (number_A, number_B)}");
Console.WriteLine($"{number_A} в степени {number_B} (pow) -> {GetDegreePow (number_A, number_B)}");

int GetDegreeCycle (int number_A, int number_B) {
    if (number_B == 0)
        return 1;

    int result = number_A;
    for (int i = 1; i < number_B; i++)
    {
        result = result * number_A;
    }    
    
    return result;    
}

double GetDegreePow (int number_A, int number_B) {
    
    double result = Math.Pow(number_A, number_B);
    return result;
}
