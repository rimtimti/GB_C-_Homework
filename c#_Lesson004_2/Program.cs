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
int sum;
for (sum = 0; x != 0;)
{
    sum += x % 10;
    x/=10;
}
return (Math.Abs(sum));
}
