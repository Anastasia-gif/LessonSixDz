/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5  7 -2  -0,2

1 -3, 3 8  -9,9

8 7, 8 -7, 1 9
*/

Console.WriteLine("Введите количество rows");
int countRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество columns");
int countColumns = Convert.ToInt32(Console.ReadLine());

var random = new Random();

double[,] FullMatrixArray(int countRow, int countColumn)
{
    double[,] matrixArray = new double[countRow, countColumn];
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = random.NextDouble();
        }
    }
    return matrixArray;
}

void PrintMatrixArray(double[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write(matrixArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMatrixArray(FullMatrixArray(countRows,countColumns));