using System;

Console.Clear();
Console.WriteLine("Это программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
//Здесь бы сделать проверку, возможно, введено нецелое число или текст, но я пока не знаю как
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
//Здесь бы сделать проверку, возможно, введено нецелое число или текст, но я пока не знаю как
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
//Здесь бы сделать проверку, возможно, введено нецелое число или текст, но я пока не знаю как
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.Write("Самое большое из этих чисел: "); Console.WriteLine(max);
