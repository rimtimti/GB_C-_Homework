using System;

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
//Здесь бы сделать проверку, возможно, введено нецелое число или текст, но я пока не знаю как
if (number < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
}
Console.WriteLine();
int x = 2;
while (x <= number)
{
    Console.WriteLine(x);
    x = x + 2;
}
