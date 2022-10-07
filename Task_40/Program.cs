//  Принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Правило: сумма двух сторон треугольника всегда больше третьей.

Console.Clear();
Console.Write("Введите сторону А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите сторону B: ");
int B = int.Parse(Console.ReadLine());

Console.Write("Введите сторону C: ");
int C = int.Parse(Console.ReadLine());

IsTriangle(A, B, C);

void IsTriangle (int A, int B, int C)
{
    if ((A + B > C) && (A + C > B) && (B + C > A))
        Console.WriteLine("Треугольник существует");
    else    
        Console.WriteLine("Треугольник не существует");        
}

// другое решение
Console.Write("Введите стороны треугольника через пробел: ");

string[] st=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]);
int c = int.Parse(st[2]);
int b = int.Parse(st[1]);

if(IsTriangle_2(a, b, c) == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsTriangle_2(int a,int b,int c)
{
    return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}