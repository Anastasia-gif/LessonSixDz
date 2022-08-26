/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int countRows = 3;
int countColumns = 3;
var random = new Random();

int[,] FillMatrixArray(int countRow, int countColumn)
{
    int[,] matrixArray = new int[countRow, countColumn];
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = random.Next(1, 10);

        }
    }
    return matrixArray;
}

void PrintMatrixArray(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write(matrixArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] FindingAvgElemInMartix(int[,] matrixArray)
{
    double[] avgColumn = new double[matrixArray.GetLength(1)];
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrixArray.GetLength(0); i++)
        {
            sum += matrixArray[i, j];
        }
        avgColumn[j] = sum / matrixArray.GetLength(1);
    }
    return avgColumn;

}

var matrixArray = FillMatrixArray(countRows, countColumns);
PrintMatrixArray(matrixArray);
double[] avgColumn = FindingAvgElemInMartix(matrixArray);

foreach (double i in avgColumn)
{
    Console.Write(i + "\t");
}