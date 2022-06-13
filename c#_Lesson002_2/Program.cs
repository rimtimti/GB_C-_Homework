using System;

Console.Clear();
Console.WriteLine("Это программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
//В задании нет уточнения, с какой стороны третья цифра, поэтому я сделал третью СПРАВА, то есть число сотен.
int number;
Console.WriteLine("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out number))
    {
    Console.Write("Ошибка ввода числа!");
    return;
    }
int x = Math.Abs(number) / 100;
if (x == 0)
{
    Console.WriteLine("Третьей цифры у этого числа нет!");
    return;
}
else
{
    x = x % 10;
}
Console.WriteLine("Третья цифра этого числа:");
Console.WriteLine(x);