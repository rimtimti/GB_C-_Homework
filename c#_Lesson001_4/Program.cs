using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int number;
Console.WriteLine("Введите целое положительное число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число или ноль!");
    return;
}
Console.WriteLine("Все четные числа");
int x = 2;
while (x <= number)
{
    Console.WriteLine(x);
    x = x + 2;
}
