// принимает на вход координаты двух точек и находит расстояние между ними
// A(3,6), B(2,1) -> 5,09
// A(7,-5), B(1,-1) -> 7,21
// формула: квадратный корень от (xb - xa)2 + (yb - ya)2

Console.Clear();
Console.Write("Введите координату xA: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату yA: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату xB: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату xA: ");
int yB = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");

Console.WriteLine($"Расстояние между точками: {result:f3}"); // округление и вывод трех знаков после запятой

Console.WriteLine($"Расстояние между точками: {result.ToString("0.000")}");