using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
int number;
Console.WriteLine("Введите целое положительное трехзначное число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели некорректное число!");
    return;
}

int x = (number / 10) % 10;
Console.WriteLine("Вторая цифра этого числа:");
Console.WriteLine(x);