/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int countRows = Convert.ToInt32(Console.ReadLine());
int countColums = Convert.ToInt32(Console.ReadLine());
var random = new Random();
Console.WriteLine("Ввывод несортированного массива ");


int[,] FillMatrix(int countRow, int countCol)
{
    int[,] matrix = new int[countRow, countCol];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 50);
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

int[,] MatrixSortingFromCol(int[,] matrix)
{
    int lengthRow = matrix.GetLength(0);
    int lengthCol = matrix.GetLength(1);

    int[] row = new int[lengthCol];
            for (int i = 0; i < lengthRow; i++)
            {
                for (int j = 0; j < lengthCol; j++)
                    row[j] = matrix[i, j];
                BubbleSort(row);
                Insert(true, i, row, matrix);
            }
    return matrix;
}

void BubbleSort(int[] inArray){
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] < inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
}

 void Insert(bool isRow, int dim, int[] source, int[,] matrix){
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    matrix[dim, k] = source[k];
                else
                    matrix[k, dim] = source[k];
            }
        }
}

var matrix = FillMatrix(countRows, countColums);
PrintMatrix(matrix);

Console.WriteLine("Результат: ");

var sortMatrix = MatrixSortingFromCol(matrix);
PrintMatrix(sortMatrix);