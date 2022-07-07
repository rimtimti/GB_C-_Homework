using System;
using static System.Console;

Clear();
WriteLine ("Это программа, которая задаёт два двумерных массива заданного размера, заполненных случайными целыми числами.");
WriteLine ("Затем печатает их и находит произведение двух матриц.");
WriteLine ("Внимание! Число столбцов матрицы 1 должно быть равно числу строк матрицы 2 !.");
Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в первом массиве (через пробел или запятую): ");
int [] parametersMatrix1 = GetArrayFromString(ReadLine());
int [,] arr1 = RandomArray(parametersMatrix1);
Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное во втором массиве (через пробел или запятую): ");
int [] parametersMatrix2 = GetArrayFromString(ReadLine());
int [,] arr2 = RandomArray(parametersMatrix2);

PrintArray(arr1);
WriteLine("------------------------");
PrintArray(arr2);

if (arr1.GetLength(1) == arr2.GetLength(0)) WriteLine("Произаедение этих двух матриц равно:");
else WriteLine("Эти матрицы перемножить нельзя!");

PrintArray(MatrixMultiplication(arr1,arr2));

int [,] MatrixMultiplication (int [,] array1, int [,] array2)
{
    int [,] result = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result [i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return result;
}

int [] GetArrayFromString (string arrayStr)
{
    string [] ArS = arrayStr.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int [ArS.Length];
    for (int i = 0; i < ArS.Length; i++)
    {
        result [i] = int.Parse(ArS[i]);
    }
    return result;
}

int [,] RandomArray(int [] array)
{
    int [,] result = new int [array [0], array [1]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(array [2], array [3] + 1);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array [i,j]}\t");
        }
        WriteLine();
    }
}