// вывод названия дня недели по номеру
Console.Write("Введите число дня недели: ");
int day_number = int.Parse(Console.ReadLine());

if (day_number < 1||day_number > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if (day_number == 1) Console.Write("Понедельник");
if (day_number == 2) Console.Write("Вторник");
if (day_number == 3) Console.Write("Среда");
if (day_number == 4) Console.Write("Четверг");
if (day_number == 5) Console.Write("Пятница");
if (day_number == 6) Console.Write("Суббота");
if (day_number == 7) Console.Write("Воскресенье");
