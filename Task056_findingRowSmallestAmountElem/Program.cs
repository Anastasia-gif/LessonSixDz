/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int countRows = Convert.ToInt32(Console.ReadLine());
int countColums = Convert.ToInt32(Console.ReadLine());
var random = new Random();

Console.WriteLine("Ввод массива");

int[,] FillMatrix(int countRow, int countCol)
{
    int[,] matrix = new int[countRow, countCol];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 20);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindingSmallestSumRow(int[,] matrix)
{
    int[] sumElemStr = new int[matrix.GetLength(0)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        sumElemStr[i] = sumRow;
    }





    int minSumRow = int.MaxValue;
    int indexMinRow = -1;
    for (int i = 1; i < sumElemStr.Length; i++)
    {
        if (sumElemStr[i] < minSumRow)
        {
            minSumRow = sumElemStr[i];
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

var matrix = FillMatrix(countRows, countColums);
PrintMatrix(matrix);
int indexMinSumRow = FindingSmallestSumRow(matrix);
Console.WriteLine($"минимальная сумма строки, её индекс = {indexMinSumRow}");