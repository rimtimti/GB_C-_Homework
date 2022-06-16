using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
int number;
Console.Write("Введите положительное целое число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number < 1)
{
    Console.WriteLine("Вы ввели не то число!");
    return;
}
for (int x = 1; x <= number; x++)
{
    Console.WriteLine(Math.Pow(x,3));
}