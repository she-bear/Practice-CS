// принимает на вход число и выдает количество цифр в числе: 456 -> 3, 78 -> 2, 89126 -> 5
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {GetCount (number)}");

int GetCount (int number) {
    int count = 0;
    
    while (number > 0) {
        count++;
        number /= 10; // аналог number = number/10; 
    }
    
    return count;    
}