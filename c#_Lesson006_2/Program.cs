using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая ищет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
double a1;
Write("Введите k1: ");
if (!double.TryParse(ReadLine(), out a1))
{
    Write("Ошибка ввода числа!");
    return;
}
double s1;
Write("Введите b1: ");
if (!double.TryParse(ReadLine(), out s1))
{
    Write("Ошибка ввода числа!");
    return;
}
double a2;
Write("Введите k2: ");
if (!double.TryParse(ReadLine(), out a2))
{
    Write("Ошибка ввода числа!");
    return;
}
double s2;
Write("Введите b2: ");
if (!double.TryParse(ReadLine(), out s2))
{
    Write("Ошибка ввода числа!");
    return;
}

if (a1 == a2 && s1 == s2) 
{
    WriteLine("Это одна прямая!");
    return;
}
if (a1 == a2)
{
    WriteLine("Параллельные прямые не пересекаются!");
    return;
}

WriteLine ($"Точка пересечения указанных прямых: ({GetXpointIntersectionLines(a1, s1, a2, s2)} ; {a1 * GetXpointIntersectionLines(a1, s1, a2, s2) + s1})");

double GetXpointIntersectionLines(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}