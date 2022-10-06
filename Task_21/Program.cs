// принимает на вход координаты двух точек и находит расстояние между ними в 3D-пространстве
// A(3,6, 8), B(2,1,-7) -> 15,84
// A(7,-5,0), B(1,-1,9) -> 11,53
// формула: квадратный корень от (xb - xa)2 + (yb - ya)2 + (zb - za)

Console.Clear();
Console.Write("Введите координату xA: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату yA: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату zA: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите координату xB: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату yB: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координату zB: ");
int zB = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");
