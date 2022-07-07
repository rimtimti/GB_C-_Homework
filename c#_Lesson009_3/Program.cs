using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая просит у пользователя ввести с клавиатуры неотрицательных числа M и N.");
WriteLine("Затем выведет вычисление функции Аккермана с помощью рекурсии в промежутке от M до N.");

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

if (number1 < 0 | number2 < 0)
{
    WriteLine("Одно или оба числа отрицательные!");
}
else WriteLine($"Функция Аккермана: А({number1}, {number2}) = {functionAccerman(number1, number2)}");


int functionAccerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return functionAccerman(m - 1, 1);
    return functionAccerman(m - 1, functionAccerman(m, n - 1));
}