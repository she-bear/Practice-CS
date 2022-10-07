// Создание копии заданного массива с помощью поэлементного копирования
// Решение преподавателя

// чтобы дальше нигде не писать "Console"
using System;
using static System.Console;

Clear();
// способ поместить числа из консоли в массив
Write("Введите через пробел b1, k1, b2, k2: ");
string[] f = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK2 - inK1);
    result[1] = inK1 * result[0] + inB1;
    return result;
}