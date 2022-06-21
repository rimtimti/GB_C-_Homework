using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт массив из N элементов и выводит их на экран.");
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
PrintArray(ar);

void PrintArray(int [] array)
{
    Write ("[");
    for (int y = 0; y < array.Length-1; y++)
    {
        Write($"{array [y]},");
    }
    Write($"{array[array.Length-1]}]");
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