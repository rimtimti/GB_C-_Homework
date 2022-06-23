using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт одномерный массив, заполненный случайными числами и выводит сумму элементов, стоящих на нечётных позициях.");
int number;
Write("Введите необходимое число элементов массива: ");
if (!int.TryParse(ReadLine(), out number))
{
    Write("Ошибка ввода числа!");
    return;
}
int min;
Write("Введите минимальное число, возможное в массиве: ");
if (!int.TryParse(ReadLine(), out min))
{
    Write("Ошибка ввода числа!");
    return;
}
int max;
Write("Введите максимальное число, возможное в массиве: ");
if (!int.TryParse(ReadLine(), out max))
{
    Write("Ошибка ввода числа!");
    return;
}

int [] ar = RandomArray(number, min, max);
WriteLine($"[{String.Join(", ", ar)}]");
WriteLine($"Сумма чисел, стоящих на нечетных позициях в этом массиве = {GetSumOddPosition(ar)}");

int GetSumOddPosition(int [] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j %2 != 0) sum += array [j];
    }
    return sum;
}

int [] RandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int [size];
    for (int x = 0; x < size; x++)
    {
        result [x] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}