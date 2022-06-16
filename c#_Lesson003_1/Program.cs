using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
int number;
Console.WriteLine("Введите положительное пятизначное целое число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не то число!");
    return;
}

int x = number%10*10000 + number/10%10*1000 + number/100%10*100 + number/1000%10*10 + number/10000;

if (x == number)
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("Это число не палиндром");
}
