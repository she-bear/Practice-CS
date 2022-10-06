// принимает на вход координаты точки X, Y (причем, X<>0 и Y<>0) и выдает номер четверти плоскости, в которой находится эта точка

Console.Clear();
Console.Write("Введите X<>0: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите Y<>0: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine($"{X}, {Y}: плоскость 1");    
}

if (X > 0 && Y < 0)
{
    Console.WriteLine($"{X}, {Y}: плоскость 4");    
}

if (X < 0 && Y < 0)
{
    Console.WriteLine($"{X}, {Y}: плоскость 3");    
}

if (X < 0 && Y > 0)
{
    Console.WriteLine($"{X}, {Y}: плоскость 2");    
}

if (X == 0 || Y == 0)
{
    Console.WriteLine($"X, Y не могут быть равны 0!");    
}




