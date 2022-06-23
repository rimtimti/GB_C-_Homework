using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт массив заполненный случайными положительными трёхзначными числами и выводит количество чётных чисел в массиве.");
int number;
Write("Введите необходимое число элементов массива: ");
if (!int.TryParse(ReadLine(), out number))
{
    Write("Ошибка ввода числа!");
    return;
}

int [] ar = GetRandomArray(number, 100, 999);
WriteLine($"[{String.Join(", ", ar)}]");
WriteLine($"Четных чисел в этом массиве = {GetCountEven(ar)}");

int GetCountEven(int [] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] %2 == 0) count ++;
    }
    return count;
}


int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int [size];
    for (int x = 0; x < size; x++)
    {
        result [x] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}