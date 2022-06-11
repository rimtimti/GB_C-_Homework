using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает число и выдаёт, является ли число чётным.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//Здесь бы сделать проверку, возможно, введено нецелое число или текст, но я пока не знаю как
if (number %2 == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}
