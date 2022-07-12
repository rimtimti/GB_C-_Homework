using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая задаёт двумерный массив заданного размера, заполненный случайными целыми числами.");
WriteLine("Затем программа из этого массива целых чисел удаляет строку и столбец, на пересечении которых расположен наименьший элемент.");

Write("Введите в указанном порядке (целым числом): число строк, число столбцов, минимальное и максимальное число, возможное в массиве (через пробел или запятую): ");

int[] parametersMatrix = GetArrayFromString(ReadLine());
if (parametersMatrix[0] * parametersMatrix[1] > (parametersMatrix[3] - parametersMatrix[2] + 1))
{
    WriteLine("Такой массив не заполнить неповторяющимися числами!!!");
    return;
}
int[,] arr = FillArray2FromArray1(CreateArrayUniqNumbers(parametersMatrix), parametersMatrix);
PrintArray(arr);
int [] arrS = GetPowAndColumnMin(arr);
WriteLine($"Минимальный элемент находится на позиции: {arrS[0]}, {arrS[1]}. Убираем строку и столбец, где есть это значение:");
PrintArray(DelPowAndColumnWithMinElement(arr, arrS));


int[,] DelPowAndColumnWithMinElement(int[,] array, int [] array1)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;
    int y = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i >= array1[0]) x = i + 1;
        else x = i;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j >= array1[1]) y = j + 1;
            else y = j;
            result[i, j] = array[x, y];
        }
    }
    return result;
}

int[] GetArrayFromString(string arrayStr)
{
    string[] ArS = arrayStr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[ArS.Length];
    for (int i = 0; i < ArS.Length; i++)
    {
        result[i] = int.Parse(ArS[i]);
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}

int[] GetPowAndColumnMin(int[,] array)
{
    int[] result = new int[2];
    int min = array [0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[] CreateArrayUniqNumbers(int [] array)
{
    int[] randomNumbers = new int[array[0] * array[1]];
    for (int i = 0; i < randomNumbers.GetLength(0); i++)
    {
        randomNumbers[i] = new Random().Next(array[2], array[3] + 1);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (randomNumbers[i] == randomNumbers[j])
                {
                    randomNumbers[i] = new Random().Next(array[2], array[3] + 1);
                    j = 0;
                }
            }
        }
    }
    return randomNumbers;
}

int[,] FillArray2FromArray1(int[] array1, int[] array)
{
    int[,] result = new int[array [0], array [1]];
    int count = 0;
    for (int i = 0; i < array [0]; i++)
    {
        for (int j = 0; j < array [1]; j++)
        {
            {
                result[i, j] = array1 [count];
                count++;
            }
        }
    }
    return result;
}