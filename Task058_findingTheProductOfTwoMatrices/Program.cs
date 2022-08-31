/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int countRowsMatrixOne = Convert.ToInt32(Console.ReadLine());
int countColumsMatrixOne = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте раазмер второй матрицы");

int countRowsMatrixTwo = Convert.ToInt32(Console.ReadLine());
int countColumsMatrixTwo = Convert.ToInt32(Console.ReadLine());

var random = new Random();

int[,] FillMatrixOne(int countRow, int countCol)
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

int[,] FillMatrixTwo(int countRow, int countCol)
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

int CalcElement(int[,] matrixOne, int[,] matrixTwo, int row, int col)
{
    int sum = 0;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        sum += matrixOne[row, i] * matrixTwo[i, col];
    }
    return sum;
}

int[,] FindingProductThoMatrix(int[,] matrixOne, int[,] matrixTwo)
{

    int[,] resultingMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    
    for (int row = 0; row < resultingMatrix.GetLength(0); row++)
    {
        for (int col = 0; col < resultingMatrix.GetLength(1); col++)
        {
            resultingMatrix[row, col] = CalcElement(matrixOne, matrixTwo, row, col);
        }
    }
    return resultingMatrix;
}


var matrixOne = FillMatrixOne(countRowsMatrixOne, countColumsMatrixTwo);

Console.WriteLine("Первая матрица: ");

PrintMatrix(matrixOne);

Console.WriteLine("Вторая матрица: ");

var matrixTwo = FillMatrixTwo(countRowsMatrixTwo, countColumsMatrixTwo);

PrintMatrix(matrixTwo);

var resultMatrix = FindingProductThoMatrix(matrixOne, matrixTwo);

Console.WriteLine("результирующая матрица: ");

PrintMatrix(resultMatrix);


