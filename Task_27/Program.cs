// принимает на вход число и выдает сумму цифр в числе: 452 -> 11, 82 -> 10, 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {GetCount (number)}");

int GetCount (int number) {
    int sum = 0;
    
    while (number > 0) {
        
        int digit = number % 10;
        number /= 10; // аналог number = number/10; 
        sum = sum + digit;
    }
    
    return sum;    
}
