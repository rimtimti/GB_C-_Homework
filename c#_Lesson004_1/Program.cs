using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int number1;
Write("Введите целое число: ");
if (!int.TryParse(ReadLine(), out number1))
{
    Write("Ошибка ввода числа!");
    return;
}
int number2;
Write("Введите целое число: ");
if (!int.TryParse(ReadLine(), out number2))
{
    Write("Ошибка ввода числа!");
    return;
}

WriteLine ($"{number1} в степени {number2} равно {PowAB(number1, number2)}");
if (number1!=number2)
WriteLine ($"{number2} в степени {number1} равно {PowAB(number2, number1)}");

double PowAB(int a, int b)
{
double x = Math.Pow(a, b);
return (x);
}
