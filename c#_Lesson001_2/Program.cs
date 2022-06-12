using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход три целых числа и выдаёт максимальное из этих чисел.");
int number1;
Console.WriteLine("Введите первое число: ");
if (!int.TryParse(Console.ReadLine(), out number1))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int number2;
Console.WriteLine("Введите второе число: ");
if (!int.TryParse(Console.ReadLine(), out number2))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int number3;
Console.WriteLine("Введите третье число: ");
if (!int.TryParse(Console.ReadLine(), out number3))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.Write("Самое большое из этих чисел: "); Console.WriteLine(max);
