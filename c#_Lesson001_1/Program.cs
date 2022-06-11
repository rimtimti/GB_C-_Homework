using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write (number1); Console.Write (" больше "); Console.WriteLine (number2);
}
else
{
    Console.Write (number2); Console.Write (" больше "); Console.WriteLine (number1);
}
    