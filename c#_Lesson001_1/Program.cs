using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает два целых числа и выдаёт, какое число большее, а какое меньшее.");
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
if (number1 > number2)
{
    Console.Write(number1); Console.Write(" больше "); Console.WriteLine(number2);
}
else
{
    Console.Write(number2); Console.Write(" больше "); Console.WriteLine(number1);
}
