﻿// Выводит случайное трехзначное число и удаляет вторую цифру этого числа: 456 -> 46
Console.Clear();
int num = new Random().Next(100, 1000);
int result = (num / 100) * 10 + num % 10; 

Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num/100}{num%10}");
