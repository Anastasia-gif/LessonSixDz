/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)
*/

int countRows = 7;
int countColumns = 5;
var random = new Random();

Console.WriteLine("Введите номер строки");
int posElemRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер колонки");
int posElemCol = Convert.ToInt32(Console.ReadLine());

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

void Checked(int[,] matrixArray, int posElemRow, int posElemCol)
{
    if (posElemRow < matrixArray.GetLength(0) && posElemCol < matrixArray.GetLength(1))
    {
        Console.WriteLine($"Да есть такой элемент {matrixArray[posElemRow, posElemCol]}");
    }
    else
    {
        Console.WriteLine($"Нет такого элемента");
    }

}
 
var matrix = FillMatrixArray(countRows, countColumns);

PrintMatrixArray(matrix);
Checked(matrix, posElemRow, posElemCol);