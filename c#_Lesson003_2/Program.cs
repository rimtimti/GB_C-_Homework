using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
int ax;
Console.WriteLine("Точка А. Введите координату Х : ");
if (!int.TryParse(Console.ReadLine(), out ax))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int ay;
Console.WriteLine("Точка А. Введите координату Y : ");
if (!int.TryParse(Console.ReadLine(), out ay))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int az;
Console.WriteLine("Точка А. Введите координату Z : ");
if (!int.TryParse(Console.ReadLine(), out az))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int bx;
Console.WriteLine("Точка B. Введите координату Х : ");
if (!int.TryParse(Console.ReadLine(), out bx))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int by;
Console.WriteLine("Точка B. Введите координату Y : ");
if (!int.TryParse(Console.ReadLine(), out by))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int bz;
Console.WriteLine("Точка B. Введите координату Z : ");
if (!int.TryParse(Console.ReadLine(), out bz))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
double lenght = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));

Console.WriteLine($"Расстояние между точками А и В равно {lenght:f2}");