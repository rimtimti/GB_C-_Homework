using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт массив чисел и выводит разницу между максимальным и минимальным элементом массива.");
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
WriteLine($"Разница между максимальным и минимальным элементом массива = {GetMax(ar)-GetMin(ar)}");



int GetMin(int [] array)
{
    int min = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < min) min = array [j];
    }
    return min;
}

int GetMax(int [] array)
{
    int max = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max) max = array [j];
    }
    return max;
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