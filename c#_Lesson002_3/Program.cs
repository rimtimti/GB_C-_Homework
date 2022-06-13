using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
int number;
Console.WriteLine("Введите номер дня недели: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели нет!");
    return;
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Ура, это выходной!");
}
else
{
    Console.WriteLine("Это рабочий день");
}
