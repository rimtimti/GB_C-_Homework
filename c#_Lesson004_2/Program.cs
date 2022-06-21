using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
int number;
Write("Введите целое число: ");
if (!int.TryParse(ReadLine(), out number))
{
    Write("Ошибка ввода числа!");
    return;
}

WriteLine ($"Сумма цифр в числе {number} равна {SumNumInNum(number)}");

int SumNumInNum(int x)
{
int sum, a;
for (sum = 0; x != 0; a = 0)
{
    a = x % 10;
    sum += a;
    x/=10;
}
return (Math.Abs(sum));
}
