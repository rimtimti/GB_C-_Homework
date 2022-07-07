using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая просит у пользователя ввести с клавиатуры натуральные числа M и N. Затем выведет произведение натуральных чисел в промежутке от M до N.");

int number1;
Write("Введите целое число М: ");
if (!int.TryParse(ReadLine(), out number1))
{
    Write("Ошибка ввода числа!");
    return;
}
int number2;
Write("Введите целое число N: ");
if (!int.TryParse(ReadLine(), out number2))
{
    Write("Ошибка ввода числа!");
    return;
}

if (number1 <= 0 | number2 <= 0)
{
    WriteLine("Одно или оба числа ненатуральные!");
}
else WriteLine($"Произведение чисел от {number1} до {number2} равно: {multiplicationFromTo(number1, number2)}");


int multiplicationFromTo (int x, int y)
{
    if (y == x) return x;
    else return y * multiplicationFromTo(x, y - 1);
}