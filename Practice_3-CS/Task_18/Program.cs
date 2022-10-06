// по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();
Console.Write("Введите номер четверти: ");
int qnumber = int.Parse(Console.ReadLine());


switch (qnumber)
{
    case 1:
        Console.WriteLine($"case: X>0 и Y>0");
        break;

    case 2:
        Console.WriteLine($"case: X<0 и Y>0");
        break;

    case 3:
        Console.WriteLine($"case: X<0 и Y<0");
        break;

    case 4:
        Console.WriteLine($"case: X>0 и Y<0");
        break;  

    default:
        Console.WriteLine($"case: Введено неверное число!");
        break;

}