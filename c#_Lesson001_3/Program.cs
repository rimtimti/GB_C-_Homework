using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает число и выдаёт, является ли число чётным.");
int number;
Console.WriteLine("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number %2 == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}
